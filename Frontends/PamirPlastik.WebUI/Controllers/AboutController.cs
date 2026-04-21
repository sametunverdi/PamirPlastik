using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.Dto.AboutDtos;

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

            var responseMessage = await client.GetAsync("https://localhost:7184/api/Abouts/GetAboutPage");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<ResultAboutPageDto>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
