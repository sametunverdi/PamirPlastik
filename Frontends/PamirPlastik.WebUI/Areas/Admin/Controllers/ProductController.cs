using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.CategoryDtos;
using PamirPlastik.WebUI.DTOs.ProductDtos;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Products");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }

            return View(new List<ResultProductDto>());
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await GetCategoryListForDropdown();
            await GetColorListForCheckboxes();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto createProductDto, IFormFile? imageFile, List<IFormFile>? galleryImages, List<int> ColorIDs)
        {
            createProductDto.Status = true;
            
            // Slug olu�tur
            if (string.IsNullOrEmpty(createProductDto.Slug_TR) && !string.IsNullOrEmpty(createProductDto.Name_TR))
            {
                createProductDto.Slug_TR = createProductDto.Name_TR.ToLower().Replace(" ", "-").Replace("�", "i").Replace("�", "g").Replace("�", "u").Replace("�", "s").Replace("�", "o").Replace("�", "c");
            }
            if (string.IsNullOrEmpty(createProductDto.Slug_EN) && !string.IsNullOrEmpty(createProductDto.Name_EN))
            {
                createProductDto.Slug_EN = createProductDto.Name_EN.ToLower().Replace(" ", "-");
            }

            // Dosya Y�kleme
            if (imageFile != null && imageFile.Length > 0)
            {
                var extension = Path.GetExtension(imageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(((Directory.GetCurrentDirectory() ?? "") ?? ""),  "wwwroot/images/products", newImageName);
                using (var image = await Image.LoadAsync(imageFile.OpenReadStream()))
                {
                    if (image.Width > 1200) { image.Mutate(x => x.Resize(1200, 0)); }
                    var encoder = new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder { Quality = 75 };
                    await image.SaveAsync(location, encoder);
                }
                createProductDto.MainImageUrl = "/images/products/" + newImageName;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/Products", stringContent);


            if (responseMessage.IsSuccessStatusCode)
            {
                var idStr = await responseMessage.Content.ReadAsStringAsync();
                if (int.TryParse(idStr, out int newId))
                {
                    await HandleGalleryImages(newId, galleryImages);
                    
                    if (ColorIDs != null && ColorIDs.Any())
                    {
                        var requestObj = new { ProductID = newId, ColorIDs = ColorIDs };
                        var colorJsonData = JsonConvert.SerializeObject(requestObj);
                        var colorStringContent = new StringContent(colorJsonData, Encoding.UTF8, "application/json");
                        await client.PostAsync("https://localhost:7184/api/ProductColors", colorStringContent);
                    }
                }
                TempData["SuccessMessage"] = "�r�n ba�ar�yla kaydedildi.";
                return RedirectToAction("Index", "Product", new { area = "Admin" });
            }

            TempData["ErrorMessage"] = "�r�n kay�t edilemedi. L�tfen zorunlu alanlar� kontrol edin.";
            await GetCategoryListForDropdown();
            return View(createProductDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            await GetCategoryListForDropdown();
            await GetColorListForCheckboxes();
            
            var selectedColors = await GetSelectedColorsForProduct(id);
            ViewBag.SelectedColors = selectedColors;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/Products/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
                var imagesResponse = await client.GetAsync($"https://localhost:7184/api/ProductImages/ByProductId/{id}");
                if (imagesResponse.IsSuccessStatusCode)
                {
                    var imagesJson = await imagesResponse.Content.ReadAsStringAsync();
                    ViewBag.ExistingGalleryImages = JsonConvert.DeserializeObject<System.Collections.Generic.List<PamirPlastik.WebUI.DTOs.ProductDtos.ResultProductImageDto>>(imagesJson);
                }
                return View(value);
            }
            return RedirectToAction("Index", "Product", new { area = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProductDto updateProductDto, IFormFile? imageFile, string? MainImageUrl, List<int> ColorIDs)
        {
            // Slug olu�tur
            if (string.IsNullOrEmpty(updateProductDto.Slug_TR) && !string.IsNullOrEmpty(updateProductDto.Name_TR))
            {
                updateProductDto.Slug_TR = updateProductDto.Name_TR.ToLower().Replace(" ", "-").Replace("�", "i").Replace("�", "g").Replace("�", "u").Replace("�", "s").Replace("�", "o").Replace("�", "c");
            }
            if (string.IsNullOrEmpty(updateProductDto.Slug_EN) && !string.IsNullOrEmpty(updateProductDto.Name_EN))
            {
                updateProductDto.Slug_EN = updateProductDto.Name_EN.ToLower().Replace(" ", "-");
            }

            // Dosya Y�kleme
            if (imageFile != null && imageFile.Length > 0)
            {
                var extension = Path.GetExtension(imageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(((Directory.GetCurrentDirectory() ?? "") ?? ""),  "wwwroot/images/products", newImageName);
                using (var image = await Image.LoadAsync(imageFile.OpenReadStream()))
                {
                    if (image.Width > 1200) { image.Mutate(x => x.Resize(1200, 0)); }
                    var encoder = new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder { Quality = 75 };
                    await image.SaveAsync(location, encoder);
                }
                updateProductDto.MainImageUrl = "/images/products/" + newImageName;
            }
            else
            {
                updateProductDto.MainImageUrl = MainImageUrl; // Eski resmi tut
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/Products", stringContent);


            if (responseMessage.IsSuccessStatusCode)
            {
                if (ColorIDs != null)
                {
                    var colorCommand = new { ProductID = updateProductDto.ProductID, ColorIDs = ColorIDs };
                    var colorJson = JsonConvert.SerializeObject(colorCommand);
                    var colorContent = new StringContent(colorJson, System.Text.Encoding.UTF8, "application/json");
                    await client.PostAsync("https://localhost:7184/api/ProductColors", colorContent);
                }

                TempData["SuccessMessage"] = "�r�n ba�ar�yla g�ncellendi.";
                return RedirectToAction("Index", "Product", new { area = "Admin" });
            }

            TempData["ErrorMessage"] = "�r�n g�ncellenemedi. L�tfen alanlar� kontrol edin.";
            await GetCategoryListForDropdown();
            return View(updateProductDto);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteGalleryImage(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/ProductImages/{id}");
            
            if (responseMessage.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }
            return Json(new { success = false, message = "Resim silinemedi." });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/Products/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, message = "�r�n silinemedi." });
        }

        private async Task GetCategoryListForDropdown()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                List<SelectListItem> categoryValues = (from x in values
                                                       select new SelectListItem
                                                       {
                                                           Text = x.Name_TR,
                                                           Value = x.CategoryID.ToString()
                                                       }).ToList();
                ViewBag.v = categoryValues;
            }
            else
            {
                ViewBag.v = new List<SelectListItem>();
            }
        }

        private async Task GetColorListForCheckboxes()
        {
            var client = _httpClientFactory.CreateClient();
            // Note: API port for Colors seems to be 7165 in ColorController, but Products is 7184. Let's use 7184 if they are all in WebApi. 
            // Wait, in ColorController I used 7165, but in ProductController it's 7184. WebApi port is usually one of them. Let's stick to 7184.
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Colors");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<PamirPlastik.WebUI.DTOs.ColorDtos.ResultColorDto>>(jsonData);
                ViewBag.Colors = values;
            }
            else
            {
                ViewBag.Colors = new List<PamirPlastik.WebUI.DTOs.ColorDtos.ResultColorDto>();
            }
        }

        private async Task<List<int>> GetSelectedColorsForProduct(int productId)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/ProductColors/{productId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<int>>(jsonData);
                return values ?? new List<int>();
            }
            return new List<int>();
        }

        private async Task AssignColorsToProduct(int productId, List<int> colorIds)
        {
            var client = _httpClientFactory.CreateClient();
            var requestObj = new { ProductID = productId, ColorIDs = colorIds ?? new List<int>() };
            var jsonData = JsonConvert.SerializeObject(requestObj);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7184/api/ProductColors", stringContent);
        }

        private async Task HandleGalleryImages(int productId, List<IFormFile>? galleryImages)
        {
            if (galleryImages == null || !galleryImages.Any()) return;

            var client = _httpClientFactory.CreateClient();
            var directoryPath = Path.Combine(((Directory.GetCurrentDirectory() ?? "") ?? ""),  "wwwroot/images/products");
            if (directoryPath != null && !Directory.Exists(directoryPath)) { Directory.CreateDirectory(directoryPath); }

            foreach (var file in galleryImages)
            {
                if (file.Length > 0)
                {
                    var extension = Path.GetExtension(file.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var location = Path.Combine(directoryPath, newImageName);
                    
                    using (var image = await Image.LoadAsync(file.OpenReadStream()))
                {
                    if (image.Width > 1200) { image.Mutate(x => x.Resize(1200, 0)); }
                    var encoder = new SixLabors.ImageSharp.Formats.Jpeg.JpegEncoder { Quality = 75 };
                    await image.SaveAsync(location, encoder);
                }

                    var imageUrl = "/images/products/" + newImageName;
                    var requestObj = new { ProductID = productId, ImageUrl = imageUrl };
                    var jsonData = JsonConvert.SerializeObject(requestObj);
                    var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    await client.PostAsync("https://localhost:7184/api/ProductImages", stringContent);
                }
            }
        }
    }
}
