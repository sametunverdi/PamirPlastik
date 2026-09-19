using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ContactDtos;
using PamirPlastik.WebUI.DTOs.SocialMediaDtos;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PamirPlastik.WebUI.ViewComponents.Layout
{
    public class _LayoutTopBarComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _LayoutTopBarComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseContact = await client.GetAsync("https://localhost:7184/api/Contacts");
            if (responseContact.IsSuccessStatusCode)
            {
                var jsonContact = await responseContact.Content.ReadAsStringAsync();
                var valuesContact = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonContact);
                ViewBag.Contact = valuesContact?.FirstOrDefault();
            }

            var responseSocial = await client.GetAsync("https://localhost:7184/api/SocialMedias");
            if (responseSocial.IsSuccessStatusCode)
            {
                var jsonSocial = await responseSocial.Content.ReadAsStringAsync();
                var valuesSocial = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonSocial);
                return View(valuesSocial?.Where(x => x.IsActive).ToList());
            }

            return View(new List<ResultSocialMediaDto>());
        }
    }
}