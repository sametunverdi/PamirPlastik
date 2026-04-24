using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.AboutDtos;
using System.Net.Http;

namespace PamirPlastik.WebUI.ViewComponents.About
{
    public class _AboutMainComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AboutMainComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Abouts");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                // HATA BURADAYDI: List<> yerine direkt ResultAboutDto kullanıyoruz
                var value = JsonConvert.DeserializeObject<ResultAboutDto>(jsonData);

                return View(value);
            }

            return View(new ResultAboutDto());
        }
    }
}