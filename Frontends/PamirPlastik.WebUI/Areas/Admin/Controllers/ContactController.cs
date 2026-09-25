using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ContactDtos;
using PamirPlastik.WebUI.DTOs.SocialMediaDtos;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            // Fetch Social Medias for ViewBag
            var smResponse = await client.GetAsync("https://localhost:7184/api/SocialMedias");
            if (smResponse.IsSuccessStatusCode)
            {
                var smJson = await smResponse.Content.ReadAsStringAsync();
                var smValues = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(smJson);
                ViewBag.SocialMedias = smValues;
            }

            var responseMessage = await client.GetAsync("https://localhost:7184/api/Contacts");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                
                if (values != null && values.Any())
                {
                    var contact = values.FirstOrDefault();
                    if (contact != null)
                    {
                        var updateDto = new UpdateContactDto
                        {
                            ContactID = contact.ContactID,
                            Title_TR = contact.Title_TR,
                            Title_EN = contact.Title_EN,
                            Description_TR = contact.Description_TR,
                            Description_EN = contact.Description_EN,
                            PhoneTitle_TR = contact.PhoneTitle_TR,
                            PhoneTitle_EN = contact.PhoneTitle_EN,
                            Phone = contact.Phone,
                            PhoneDescription_TR = contact.PhoneDescription_TR,
                            PhoneDescription_EN = contact.PhoneDescription_EN,
                            EmailTitle_TR = contact.EmailTitle_TR,
                            EmailTitle_EN = contact.EmailTitle_EN,
                            Email = contact.Email,
                            EmailDescription_TR = contact.EmailDescription_TR,
                            EmailDescription_EN = contact.EmailDescription_EN,
                            MapLocation = contact.MapLocation,
                            MapTitle_TR = contact.MapTitle_TR,
                            MapTitle_EN = contact.MapTitle_EN,
                            Address_TR = contact.Address_TR,
                            Address_EN = contact.Address_EN
                        };
                        return View(updateDto);
                    }
                }
            }

            return View(new UpdateContactDto());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UpdateContactDto updateContactDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            if (updateContactDto.ContactID > 0)
            {
                var responseMessage = await client.PutAsync("https://localhost:7184/api/Contacts", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    TempData["SuccessMessage"] = "\u0130leti\u015Fim bilgileri ba\u015Far\u0131yla g\u00FCncellendi.";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                var responseMessage = await client.PostAsync("https://localhost:7184/api/Contacts", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    TempData["SuccessMessage"] = "\u0130leti\u015Fim bilgileri ba\u015Far\u0131yla olu\u015Fturuldu.";
                    return RedirectToAction("Index");
                }
            }

            TempData["ErrorMessage"] = "Bir hata olu\u015Ftu. L\u00FCtfen alanlar\u0131 kontrol edin.";
            return View(updateContactDto);
        }
    }
}
