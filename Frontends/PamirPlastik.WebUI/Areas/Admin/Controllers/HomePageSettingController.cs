using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.HomePageSettingDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class HomePageSettingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public HomePageSettingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/HomePageSettings/1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                System.IO.File.WriteAllText("debug_json.txt", jsonData); var value = JsonConvert.DeserializeObject<UpdateHomePageSettingDto>(jsonData);
                return View(value ?? new UpdateHomePageSettingDto());
            }
            // If it fails or not exists, return empty model
            return View(new UpdateHomePageSettingDto());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateHomePageSettingDto updateHomePageSettingDto)
        {
            updateHomePageSettingDto.HomePageSettingID = 1; // Always update ID 1

            if (updateHomePageSettingDto.HeroImageFile != null)
            {
                var extension = Path.GetExtension(updateHomePageSettingDto.HeroImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/homepagesetting/", newImageName);
                
                var directory = Path.GetDirectoryName(location);
                if (directory != null && !Directory.Exists(directory)) { Directory.CreateDirectory(directory); }

                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await updateHomePageSettingDto.HeroImageFile.CopyToAsync(stream);
                }
                updateHomePageSettingDto.HeroImageUrl = "/images/homepagesetting/" + newImageName;
            }

            if (updateHomePageSettingDto.ProdImageFile != null)
            {
                var extension = Path.GetExtension(updateHomePageSettingDto.ProdImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/homepagesetting/", newImageName);
                
                var directory = Path.GetDirectoryName(location);
                if (directory != null && !Directory.Exists(directory)) { Directory.CreateDirectory(directory); }

                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await updateHomePageSettingDto.ProdImageFile.CopyToAsync(stream);
                }
                updateHomePageSettingDto.ProdImageUrl = "/images/homepagesetting/" + newImageName;
            }

            if (updateHomePageSettingDto.CatalogPdfFile != null)
            {
                var extension = Path.GetExtension(updateHomePageSettingDto.CatalogPdfFile.FileName);
                var newFileName = Guid.NewGuid() + extension;
                var location = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/catalogs/", newFileName);
                
                var directory = Path.GetDirectoryName(location);
                if (directory != null && !Directory.Exists(directory)) { Directory.CreateDirectory(directory); }

                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await updateHomePageSettingDto.CatalogPdfFile.CopyToAsync(stream);
                }
                updateHomePageSettingDto.CatalogPdfUrl = "/catalogs/" + newFileName;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateHomePageSettingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Since we use PUT in API
            var responseMessage = await client.PutAsync("https://localhost:7184/api/HomePageSettings", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Ana sayfa ayarları başarıyla güncellendi.";
                return RedirectToAction("Edit", "HomePageSetting", new { area = "Admin" });
            }
            
            TempData["ErrorMessage"] = "Ana sayfa ayarları güncellenirken bir hata oluştu.";
            return View(updateHomePageSettingDto);
        }
    }
}