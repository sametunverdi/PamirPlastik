using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.CategoryDtos;
using System.Text;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/Categories");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }

            return View(new List<ResultCategoryDto>());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto createCategoryDto)
        {
            createCategoryDto.Status = true; // Default as active
            
            if (createCategoryDto.ImageFile != null)
            {
                var extension = Path.GetExtension(createCategoryDto.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/category/", newImageName);
                
                var directory = Path.GetDirectoryName(location);
                if (directory != null && !Directory.Exists(directory)) { Directory.CreateDirectory(directory); }

                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await createCategoryDto.ImageFile.CopyToAsync(stream);
                }
                createCategoryDto.ImageUrl = "/images/category/" + newImageName;
            }
            else if(string.IsNullOrEmpty(createCategoryDto.ImageUrl)) 
            {
                createCategoryDto.ImageUrl = "";
            }

            // Slug oluþtur (basit versiyon)
            if(string.IsNullOrEmpty(createCategoryDto.Slug) && !string.IsNullOrEmpty(createCategoryDto.Name_TR))
            {
                createCategoryDto.Slug = createCategoryDto.Name_TR.ToLower().Replace(" ", "-").Replace("ý", "i").Replace("ð", "g").Replace("ü", "u").Replace("þ", "s").Replace("ö", "o").Replace("ç", "c");
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7184/api/Categories", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Kategori baþarýyla kaydedildi.";
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }

            TempData["ErrorMessage"] = "Kategori kayýt edilemedi. Lütfen zorunlu alanlarý kontrol edin.";
            return View(createCategoryDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7184/api/Categories/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonData);
                return View(value);
            }
            return RedirectToAction("Index", "Category", new { area = "Admin" });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateCategoryDto updateCategoryDto)
        {
            if (updateCategoryDto.ImageFile != null)
            {
                var extension = Path.GetExtension(updateCategoryDto.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine((Directory.GetCurrentDirectory() ?? ""), "wwwroot/images/category/", newImageName);
                
                var directory = Path.GetDirectoryName(location);
                if (directory != null && !Directory.Exists(directory)) { Directory.CreateDirectory(directory); }

                using (var stream = new FileStream(location, FileMode.Create))
                {
                    await updateCategoryDto.ImageFile.CopyToAsync(stream);
                }
                updateCategoryDto.ImageUrl = "/images/category/" + newImageName;
            }
            else if(string.IsNullOrEmpty(updateCategoryDto.ImageUrl)) 
            {
                updateCategoryDto.ImageUrl = "";
            }

            // Slug yoksa oluþtur
            if(string.IsNullOrEmpty(updateCategoryDto.Slug) && !string.IsNullOrEmpty(updateCategoryDto.Name_TR))
            {
                updateCategoryDto.Slug = updateCategoryDto.Name_TR.ToLower().Replace(" ", "-").Replace("ý", "i").Replace("ð", "g").Replace("ü", "u").Replace("þ", "s").Replace("ö", "o").Replace("ç", "c");
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/Categories", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Kategori baþarýyla güncellendi.";
                return RedirectToAction("Index", "Category", new { area = "Admin" });
            }

            TempData["ErrorMessage"] = "Kategori güncellenemedi. Lütfen alanlarý kontrol edin.";
            return View(updateCategoryDto);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7184/api/Categories/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return Json(new { success = true });
            }

            return Json(new { success = false, message = "Kategori silinemedi. Lütfen önce bu kategoriye baðlý ürünleri silin veya kategorilerini deðiþtirin." });
        }
    }
}
