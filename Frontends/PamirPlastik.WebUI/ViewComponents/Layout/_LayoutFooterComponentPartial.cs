using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ContactDtos;
using PamirPlastik.WebUI.DTOs.SocialMediaDtos;
using PamirPlastik.WebUI.DTOs.DeveloperSettingDtos;
using PamirPlastik.WebUI.DTOs.CategoryDtos;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PamirPlastik.WebUI.ViewComponents.Layout
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _LayoutFooterComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            
            // 1. Fetch Contact
            var responseContact = await client.GetAsync("https://localhost:7184/api/Contacts");
            if (responseContact.IsSuccessStatusCode)
            {
                var jsonContact = await responseContact.Content.ReadAsStringAsync();
                var valuesContact = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonContact);
                ViewBag.Contact = valuesContact?.FirstOrDefault();
            }

            // 2. Fetch Developer Settings
            var responseDev = await client.GetAsync("https://localhost:7184/api/DeveloperSettings");
            if (responseDev.IsSuccessStatusCode)
            {
                var jsonDev = await responseDev.Content.ReadAsStringAsync();
                var valuesDev = JsonConvert.DeserializeObject<List<ResultDeveloperSettingDto>>(jsonDev);
                ViewBag.DeveloperSetting = valuesDev?.FirstOrDefault();
            }

            // 3. Fetch Categories (ShowOnHome)
            var responseCategory = await client.GetAsync("https://localhost:7184/api/Categories");
            if (responseCategory.IsSuccessStatusCode)
            {
                var jsonCategory = await responseCategory.Content.ReadAsStringAsync();
                var valuesCategory = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonCategory);
                ViewBag.FooterCategories = valuesCategory?.Where(x => x.ShowOnHome && x.Status).ToList() ?? new List<ResultCategoryDto>();
            }
            else 
            {
                ViewBag.FooterCategories = new List<ResultCategoryDto>();
            }

            // 4. Fetch Social Media
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