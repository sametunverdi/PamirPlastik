using Microsoft.AspNetCore.Mvc;
using PamirPlastik.WebUI.Models;
using System.Diagnostics;
using System.IO;

namespace PamirPlastik.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            // Ziyaretçi Sayacı (Basit dosya tabanlı sistem)
            try
            {
                string countFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "visitor_count.txt");
                int visitorCount = 0; // Sitenin geçmişini yansıtacak güzel bir başlangıç rakamı
                if (System.IO.File.Exists(countFilePath))
                {
                    string countStr = System.IO.File.ReadAllText(countFilePath);
                    if (int.TryParse(countStr, out int currentCount))
                    {
                        visitorCount = currentCount + 1;
                    }
                }
                System.IO.File.WriteAllText(countFilePath, visitorCount.ToString());
            }
            catch { }

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/HomePageSettings/1");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = Newtonsoft.Json.JsonConvert.DeserializeObject<DTOs.HomePageSettingDtos.ResultHomePageSettingDto>(jsonData);
                ViewBag.HomePageSetting = value;
                return View(value);
            }
            return View(new DTOs.HomePageSettingDtos.ResultHomePageSettingDto());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}