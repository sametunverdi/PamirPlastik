using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.AboutDtos;

namespace PamirPlastik.WebUI.ViewComponents.About
{
    public class _AboutImageComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AboutImageComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string apiPort = "7184";
            var client = _httpClientFactory.CreateClient();

            // Resimler için API'ye gidiyoruz
            var responseMessage = await client.GetAsync($"https://localhost:{apiPort}/api/AboutImages");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var images = JsonConvert.DeserializeObject<List<ResultAboutImageDto>>(jsonData);

                // NOT: Eğer istatistikleri de About tablosundan çekmek istersen 
                // buraya bir API çağrısı daha ekleyip ViewModel ile gönderebiliriz.
                // Şimdilik resim listesini gönderiyoruz.
                return View(images);
            }

            return View(new List<ResultAboutImageDto>());
        }
    }
}
