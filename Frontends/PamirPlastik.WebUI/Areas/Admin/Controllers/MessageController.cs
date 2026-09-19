using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ContactMessageDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MessageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/ContactMessages");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactMessageDto>>(jsonData);
                return View(values);
            }

            return View(new List<ResultContactMessageDto>());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/ContactMessages/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, message = "Silme işlemi başarısız oldu." });
        }

        [HttpPost]
        public async Task<IActionResult> MarkAsRead(int id)
        {
            // API'de mark-as-read için bir endpoint olmalıdır, yoksa update kullanılabilir.
            // Tasarım rehberine göre PATCH /api/contactmessages/{id}/read şeklinde bir endpoint planlandı.
            // Fakat backend'de henüz bu endpoint olmayabilir. Şu anlık varsayılan bir yaklaşım izleyelim.
            // Backend'de "GetContactMessageById" alıp "IsRead = true" yapıp "UpdateContactMessage" yapılabilir.
            
            var client = _httpClientFactory.CreateClient();
            
            // Öncelikle mevcut mesajı al
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/ContactMessages/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var message = JsonConvert.DeserializeObject<UpdateContactMessageDto>(jsonData);
                
                if (message != null)
                {
                    message.IsRead = true; // Okundu olarak işaretle
                    
                    var stringContent = new StringContent(JsonConvert.SerializeObject(message), Encoding.UTF8, "application/json");
                    var updateResponse = await client.PutAsync("https://localhost:7184/api/ContactMessages", stringContent);
                    
                    if (updateResponse.IsSuccessStatusCode)
                    {
                        return Json(new { success = true, data = message });
                    }
                }
            }

            return Json(new { success = false });
        }
    }
}
