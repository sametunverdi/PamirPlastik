using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.FairDtos;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PamirPlastik.WebUI.ViewComponents.Home
{
    public class _DefaultFairsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultFairsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Fairs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFairDto>>(jsonData);
                
                if(values != null)
                {
                    // Sadece Yaklaşan Fuarları al (IsFuture = true) ve Hepsini göster (Slider olacak)
                    values = values.Where(x => x.IsFuture).OrderByDescending(x => x.FairID).ToList();
                }

                return View(values ?? new List<ResultFairDto>());
            }
            return View(new List<ResultFairDto>());
        }
    }
}
