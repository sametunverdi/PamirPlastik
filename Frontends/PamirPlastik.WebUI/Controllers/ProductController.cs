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

        public async Task<IActionResult> Index(int? categoryId, string? searchQuery, int page = 1)
        {
            var client = _httpClientFactory.CreateClient();
            int pageSize = 9;

            string countUrl = categoryId.HasValue
                ? $"https://localhost:7184/api/Products/GetProductsByCategory?id={categoryId}"
                : "https://localhost:7184/api/Products";

            var countResponse = await client.GetAsync(countUrl);
            var filteredProducts = new List<ResultProductDto>();

            if (countResponse.IsSuccessStatusCode)
            {
                var countData = await countResponse.Content.ReadAsStringAsync();
                var allProducts = JsonConvert.DeserializeObject<List<ResultProductDto>>(countData) ?? new List<ResultProductDto>();

                // Arama filtresi uygula
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    var query = searchQuery.ToLowerInvariant();
                    allProducts = allProducts.Where(x => 
                        (!string.IsNullOrEmpty(x.Name_TR) && x.Name_TR.ToLowerInvariant().Contains(query)) || 
                        (!string.IsNullOrEmpty(x.ProductCode) && x.ProductCode.ToLowerInvariant().Contains(query))
                    ).ToList();
                }
                filteredProducts = allProducts;
            }

            int totalProductCount = filteredProducts.Count;
            
            // Manuel sayfalama (Arama ve Kategori filtreli listeyi sayfalıyoruz)
            var pagedValues = filteredProducts.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalProductCount > 0 ? (int)Math.Ceiling((double)totalProductCount / pageSize) : 1;
            ViewBag.CategoryId = categoryId;
            ViewBag.SearchQuery = searchQuery;

            return View(pagedValues);
        }

        public async Task<IActionResult> Details(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var productResponse = await client.GetAsync($"https://localhost:7184/api/Products/{id}");

            if (productResponse.IsSuccessStatusCode)
            {
                var productJson = await productResponse.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<ResultProductDto>(productJson);

                if (product != null)
                {
                    // Resimleri getir
                    var imagesResponse = await client.GetAsync($"https://localhost:7184/api/ProductImages/ByProductId/{id}");
                    if (imagesResponse.IsSuccessStatusCode)
                    {
                        var imagesJson = await imagesResponse.Content.ReadAsStringAsync();
                        product.Images = JsonConvert.DeserializeObject<List<ResultProductImageDto>>(imagesJson) ?? new List<ResultProductImageDto>();
                    }

                    // Renkleri getir
                    var colorsResponse = await client.GetAsync($"https://localhost:7184/api/Colors");
                    var productColorsResponse = await client.GetAsync($"https://localhost:7184/api/ProductColors/{id}");

                    if (colorsResponse.IsSuccessStatusCode && productColorsResponse.IsSuccessStatusCode)
                    {
                        var colorsJson = await colorsResponse.Content.ReadAsStringAsync();
                        var allColors = JsonConvert.DeserializeObject<List<PamirPlastik.WebUI.DTOs.ColorDtos.ResultColorDto>>(colorsJson) ?? new List<PamirPlastik.WebUI.DTOs.ColorDtos.ResultColorDto>();

                        var productColorsJson = await productColorsResponse.Content.ReadAsStringAsync();
                        var productColorsIds = JsonConvert.DeserializeObject<List<int>>(productColorsJson) ?? new List<int>();

                        product.Colors = allColors
                            .Where(c => productColorsIds.Contains(c.ColorID))
                            .Select(c => new ResultProductColorDto
                            {
                                ColorName = c.Name_TR,
                                ColorHex = c.HexCode
                            }).ToList();
                    }

                    return View(product);
                }
            }

            return RedirectToAction("Index");
        }
    }
}