using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ProductDtos;
using System.Net.Http;

namespace PamirPlastik.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int? categoryId, int page = 1)
        {
            var client = _httpClientFactory.CreateClient();
            int pageSize = 9;


            string countUrl = categoryId.HasValue
                ? $"https://localhost:7184/api/Products/GetProductsByCategory?id={categoryId}"
                : "https://localhost:7184/api/Products";

            var countResponse = await client.GetAsync(countUrl);
            int totalProductCount = 0;
            if (countResponse.IsSuccessStatusCode)
            {
                var countData = await countResponse.Content.ReadAsStringAsync();
                var allProducts = JsonConvert.DeserializeObject<List<ResultProductDto>>(countData);
                totalProductCount = allProducts.Count;
            }

            string url = $"https://localhost:7184/api/Products/GetProductPagination?page={page}&pageSize={pageSize}";

            if (categoryId.HasValue)
            {
                url += $"&categoryID={categoryId.Value}";
            }

            var responseMessage = await client.GetAsync(url);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);

                ViewBag.CurrentPage = page;
                ViewBag.TotalPages = (int)Math.Ceiling((double)totalProductCount / pageSize);
                ViewBag.CategoryId = categoryId;

                return View(values);
            }
            return View(new List<ResultProductDto>());
        }
    }
}