using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.AboutDtos;

namespace PamirPlastik.WebUI.ViewComponents.About
{
    public class _AboutVisionComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AboutVisionComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            // DİKKAT: Sonundaki /1'i kaldırdım, senin Main'deki gibi yaptım!
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Abouts");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultAboutDto>(jsonData);
                return View(value);
            }

            return View(new ResultAboutDto());
        }
    }
}
