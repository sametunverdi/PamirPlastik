using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ProductDtos;

namespace PamirPlastik.WebUI.ViewComponents.Home
{
    public class _DefaultFeaturedProductsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultFeaturedProductsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Products/GetFeaturedProducts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View(new List<ResultProductDto>());
        }
    }
}
