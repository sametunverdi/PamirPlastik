using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ContactMessageDtos;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactMessageDto createContactMessageDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactMessageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/ContactMessages", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Mesaj\u0131n\u0131z ba\u015Far\u0131yla g\u00F6nderildi. En k\u0131sa s\u00FCrede size d\u00F6n\u00FC\u015F yapaca\u011F\u0131z.";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Mesaj\u0131n\u0131z g\u00F6nderilirken bir hata olu\u015Ftu.";
            return View();
        }
    }
}
