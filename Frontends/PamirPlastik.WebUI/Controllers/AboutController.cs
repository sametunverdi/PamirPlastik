using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace PamirPlastik.WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var about = JsonConvert.DeserializeObject<PamirPlastik.WebUI.DTOs.AboutDtos.ResultAboutDto>(jsonData);
                return View(about);
            }
            return View();
        }
    }
}
