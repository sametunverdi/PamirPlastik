using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ColorDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ColorController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ColorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Colors");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultColorDto>>(jsonData);
                return View(values);
            }
            return View(new List<ResultColorDto>());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateColorDto createColorDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createColorDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/Colors", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Renk başarıyla eklendi.";
                return RedirectToAction("Index", "Color", new { area = "Admin" });
            }
            TempData["ErrorMessage"] = "Renk eklenirken bir hata oluştu.";
            return View(createColorDto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7184/api/Colors/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Renk başarıyla silindi.";
                return RedirectToAction("Index", "Color", new { area = "Admin" });
            }
            TempData["ErrorMessage"] = "Renk silinirken bir hata oluştu.";
            return RedirectToAction("Index", "Color", new { area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Colors/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateColorDto>(jsonData);
                return View(values);
            }
            TempData["ErrorMessage"] = "Renk bulunamadı.";
            return RedirectToAction("Index", "Color", new { area = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateColorDto updateColorDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateColorDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/Colors", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Renk başarıyla güncellendi.";
                return RedirectToAction("Index", "Color", new { area = "Admin" });
            }
            
            var errorContent = await responseMessage.Content.ReadAsStringAsync();
            TempData["ErrorMessage"] = $"Renk güncellenirken bir hata oluştu. Hata: {responseMessage.StatusCode} - {errorContent}";
            return View(updateColorDto);
        }
    }
}
