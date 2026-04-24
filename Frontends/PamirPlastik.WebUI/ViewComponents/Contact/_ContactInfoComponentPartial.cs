using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ContactDtos;

namespace PamirPlastik.WebUI.ViewComponents.Contact
{
    public class _ContactInfoComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ContactInfoComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            // Senin API portun olan 7184 üzerinden Contacts controller'ına istek atıyoruz
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Contacts");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);

                // Veritabanında iletişim bilgisi genellikle 1 satır olur, o yüzden ilk kaydı gönderiyoruz
                return View(values.FirstOrDefault());
            }

            return View();
        }
    }
}
