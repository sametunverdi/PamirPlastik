using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.AboutDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutFeatureController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutFeatureController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/AboutFeatures");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutFeatureDto>>(jsonData);
                return View(values);
            }
            return View(new List<ResultAboutFeatureDto>());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutFeatureDto createAboutFeatureDto)
        {
            createAboutFeatureDto.AboutId = 1; // Default to main about
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createAboutFeatureDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/AboutFeatures", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "İşlem başarıyla gerçekleşti.";
                return RedirectToAction("Index", "About", new { area = "Admin", tab = "features" });
            }
            TempData["ErrorMessage"] = "İşlem sırasında bir hata oluştu.";
            return View(createAboutFeatureDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/AboutFeatures");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutFeatureDto>>(jsonData);
                var target = values?.FirstOrDefault(x => x.Id == id);
                if (target != null)
                {
                    var updateDto = new UpdateAboutFeatureDto
                    {
                        Id = target.Id,
                        AboutId = 1,
                        FeatureType = target.FeatureType,
                        ValueOrIcon = target.ValueOrIcon,
                        Title_TR = target.Title_TR,
                        Title_EN = target.Title_EN,
                        Description_TR = target.Description_TR,
                        Description_EN = target.Description_EN
                    };
                    return View(updateDto);
                }
            }
            TempData["ErrorMessage"] = "Debug: Özellik Bulunamadı! Aranan ID: " + id; return RedirectToAction("Index", "About", new { area = "Admin", tab = "features" });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateAboutFeatureDto updateAboutFeatureDto)
        {
            updateAboutFeatureDto.AboutId = 1;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAboutFeatureDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/AboutFeatures", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "İşlem başarıyla gerçekleşti.";
                return RedirectToAction("Index", "About", new { area = "Admin", tab = "features" });
            }
            TempData["ErrorMessage"] = "İşlem sırasında bir hata oluştu.";
            return View(updateAboutFeatureDto);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/AboutFeatures/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }
            return Json(new { success = false, message = "Silme işlemi başarısız." });
        }
    }
}
