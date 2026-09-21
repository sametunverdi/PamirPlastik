using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.AboutDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutImageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutImageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/AboutImages");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutImageDto>>(jsonData);
                return View(values);
            }
            return View(new List<ResultAboutImageDto>());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutImageDto createAboutImageDto)
        {
            createAboutImageDto.AboutId = 1;

            if (createAboutImageDto.ImageFile != null && createAboutImageDto.ImageFile.Length > 0)
            {
                var extension = Path.GetExtension(createAboutImageDto.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var directoryPath = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/about");
                if (directoryPath != null && !Directory.Exists(directoryPath)) { Directory.CreateDirectory(directoryPath); }
                var location = Path.Combine(directoryPath, newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await createAboutImageDto.ImageFile.CopyToAsync(stream);
                }
                createAboutImageDto.ImageUrl = "/images/about/" + newImageName;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createAboutImageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/AboutImages", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Resim baþarýyla eklendi.";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Resim eklenirken bir hata oluþtu.";
            return View(createAboutImageDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/AboutImages/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateAboutImageDto>(jsonData);
                return View(value);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateAboutImageDto updateAboutImageDto, string? existingImageUrl)
        {
            updateAboutImageDto.AboutId = 1;

            if (updateAboutImageDto.ImageFile != null && updateAboutImageDto.ImageFile.Length > 0)
            {
                var extension = Path.GetExtension(updateAboutImageDto.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var directoryPath = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/about");
                if (directoryPath != null && !Directory.Exists(directoryPath)) { Directory.CreateDirectory(directoryPath); }
                var location = Path.Combine(directoryPath, newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await updateAboutImageDto.ImageFile.CopyToAsync(stream);
                }
                updateAboutImageDto.ImageUrl = "/images/about/" + newImageName;
            }
            else
            {
                updateAboutImageDto.ImageUrl = existingImageUrl;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAboutImageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/AboutImages", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Resim baþarýyla güncellendi.";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Resim güncellenirken bir hata oluþtu.";
            return View(updateAboutImageDto);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/AboutImages/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }
            return Json(new { success = false, message = "Silme iþlemi baþarýsýz." });
        }
    }
}
