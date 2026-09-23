using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.FairDtos;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PamirPlastik.WebUI.Controllers
{
    public class FairController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FairController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Fairs");

            int pageSize = 5;

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFairDto>>(jsonData);
                
                if(values == null) values = new List<ResultFairDto>();

                // Sıralama
                values = values.OrderByDescending(x => x.IsFuture).ThenByDescending(x => x.Date).ToList();

                var totalCount = values.Count;
                var totalPages = (int)System.Math.Ceiling(totalCount / (double)pageSize);

                var pagedValues = values.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                ViewBag.CurrentPage = page;
                ViewBag.TotalPages = totalPages;

                return View(pagedValues);
            }

            ViewBag.CurrentPage = 1;
            ViewBag.TotalPages = 1;
            return View(new List<ResultFairDto>());
        }
    }
}
