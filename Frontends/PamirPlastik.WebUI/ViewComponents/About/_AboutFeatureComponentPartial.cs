using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.AboutDtos;

namespace PamirPlastik.WebUI.ViewComponents.About
{
    public class _AboutFeatureComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AboutFeatureComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string apiPort = "7184";
            var client = _httpClientFactory.CreateClient();

            // DİKKAT: Endpoint'i /api/Abouts/1 yapıyoruz (Ana tablo)
            var responseMessage = await client.GetAsync($"https://localhost:{apiPort}/api/AboutFeatures");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                // Burada ResultAboutDto değil, direkt List<ResultAboutFeatureDto> bekliyoruz
                var features = JsonConvert.DeserializeObject<List<ResultAboutFeatureDto>>(jsonData);
                return View(features);
            }
            return View(new List<ResultAboutFeatureDto>());
        }
    }
}
