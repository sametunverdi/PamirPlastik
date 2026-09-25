using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.FairDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class FairController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FairController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Fairs");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFairDto>>(jsonData);
                return View(values);
            }

            return View(new List<ResultFairDto>());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFairDto createFairDto)
        {
            if (createFairDto.Img1File != null && createFairDto.Img1File.Length > 0)
            {
                var extension = Path.GetExtension(createFairDto.Img1File.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var directoryPath = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/fairs");
                if (directoryPath != null && !Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                var location = Path.Combine(directoryPath, newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await createFairDto.Img1File.CopyToAsync(stream);
                }
                createFairDto.Img1 = "/images/fairs/" + newImageName;
            }
            if (createFairDto.Img2File != null && createFairDto.Img2File.Length > 0)
            {
                var extension = Path.GetExtension(createFairDto.Img2File.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var directoryPath = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/fairs");
                if (directoryPath != null && !Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                var location = Path.Combine(directoryPath, newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await createFairDto.Img2File.CopyToAsync(stream);
                }
                createFairDto.Img2 = "/images/fairs/" + newImageName;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createFairDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/Fairs", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Fuar ba�ar�yla kaydedildi.";
                return RedirectToAction("Index", "Fair", new { area = "Admin" });
            }

            TempData["ErrorMessage"] = "Fuar kay�t edilemedi. L�tfen zorunlu alanlar� kontrol edin.";
            return View(createFairDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/Fairs/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateFairDto>(jsonData);
                return View(value);
            }
            return RedirectToAction("Index", "Fair", new { area = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateFairDto updateFairDto, string? existingImg1Url, string? existingImg2Url)
        {
            if (updateFairDto.Img1File != null && updateFairDto.Img1File.Length > 0)
            {
                var extension = Path.GetExtension(updateFairDto.Img1File.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var directoryPath = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/fairs");
                if (directoryPath != null && !Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                var location = Path.Combine(directoryPath, newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await updateFairDto.Img1File.CopyToAsync(stream);
                }
                updateFairDto.Img1 = "/images/fairs/" + newImageName;
            }
            else
            {
                updateFairDto.Img1 = existingImg1Url;
            }

            if (updateFairDto.Img2File != null && updateFairDto.Img2File.Length > 0)
            {
                var extension = Path.GetExtension(updateFairDto.Img2File.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var directoryPath = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/fairs");
                if (directoryPath != null && !Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
                var location = Path.Combine(directoryPath, newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await updateFairDto.Img2File.CopyToAsync(stream);
                }
                updateFairDto.Img2 = "/images/fairs/" + newImageName;
            }
            else
            {
                updateFairDto.Img2 = existingImg2Url;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFairDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/Fairs", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Fuar ba�ar�yla g�ncellendi.";
                return RedirectToAction("Index", "Fair", new { area = "Admin" });
            }

            TempData["ErrorMessage"] = "Fuar g�ncellenemedi. L�tfen alanlar� kontrol edin.";
            return View(updateFairDto);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFair(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/Fairs/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, message = "Fuar silinemedi." });
        }
    }
}
