using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ProductDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ProductColorController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductColorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/ProductColors");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductColorDto>>(jsonData);
                return View(values ?? new List<ResultProductColorDto>());
            }
            return View(new List<ResultProductColorDto>());
        }

        [HttpGet]
        public async Task<IActionResult> Create(int? productId)
        {
            await GetProductListForDropdown();
            var dto = new CreateProductColorDto();
            if (productId.HasValue)
            {
                dto.ProductId = productId.Value;
            }
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductColorDto createProductColorDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createProductColorDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/ProductColors", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Renk başarıyla eklendi.";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Renk eklenirken bir hata oluştu.";
            await GetProductListForDropdown();
            return View(createProductColorDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            await GetProductListForDropdown();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/ProductColors/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateProductColorDto>(jsonData);
                return View(value);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProductColorDto updateProductColorDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateProductColorDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/ProductColors", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Renk başarıyla güncellendi.";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Renk güncellenirken bir hata oluştu.";
            await GetProductListForDropdown();
            return View(updateProductColorDto);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/ProductColors/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }
            return Json(new { success = false, message = "Silme işlemi başarısız." });
        }

        private async Task GetProductListForDropdown()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Products");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                List<SelectListItem> productValues = (from x in values ?? new List<ResultProductDto>()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.Name_TR,
                                                          Value = x.ProductID.ToString()
                                                      }).ToList();
                ViewBag.Products = productValues;
            }
            else
            {
                ViewBag.Products = new List<SelectListItem>();
            }
        }
    }
}
