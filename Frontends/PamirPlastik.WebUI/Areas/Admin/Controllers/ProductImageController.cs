using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.ProductDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductImageController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductImageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/ProductImages");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductImageDto>>(jsonData);
                return View(values ?? new List<ResultProductImageDto>());
            }
            return View(new List<ResultProductImageDto>());
        }

        [HttpGet]
        public async Task<IActionResult> Create(int? productId)
        {
            await GetProductListForDropdown();
            var dto = new CreateProductImageDto();
            if (productId.HasValue)
            {
                dto.ProductId = productId.Value;
            }
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductImageDto createProductImageDto)
        {
            if (createProductImageDto.ImageFile != null && createProductImageDto.ImageFile.Length > 0)
            {
                var extension = Path.GetExtension(createProductImageDto.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products/gallery");
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                var location = Path.Combine(directoryPath, newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await createProductImageDto.ImageFile.CopyToAsync(stream);
                }
                createProductImageDto.ImageUrl = "/images/products/gallery/" + newImageName;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createProductImageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/ProductImages", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Ürün resmi başarıyla eklendi.";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Resim eklenirken bir hata oluştu.";
            await GetProductListForDropdown();
            return View(createProductImageDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            await GetProductListForDropdown();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/ProductImages/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateProductImageDto>(jsonData);
                return View(value);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProductImageDto updateProductImageDto, string? existingImageUrl)
        {
            if (updateProductImageDto.ImageFile != null && updateProductImageDto.ImageFile.Length > 0)
            {
                var extension = Path.GetExtension(updateProductImageDto.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products/gallery");
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                var location = Path.Combine(directoryPath, newImageName);
                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await updateProductImageDto.ImageFile.CopyToAsync(stream);
                }
                updateProductImageDto.ImageUrl = "/images/products/gallery/" + newImageName;
            }
            else
            {
                updateProductImageDto.ImageUrl = existingImageUrl;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateProductImageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/ProductImages", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Ürün resmi başarıyla güncellendi.";
                return RedirectToAction("Index");
            }
            TempData["ErrorMessage"] = "Resim güncellenirken bir hata oluştu.";
            await GetProductListForDropdown();
            return View(updateProductImageDto);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/ProductImages/{id}");
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