using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PamirPlastik.WebUI.DTOs.DeveloperSettingDtos;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class DeveloperSettingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DeveloperSettingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerifyBoss([FromForm] string password)
        {
            if (password == "samet123" || password == "Samet123")
            {
                Response.Cookies.Append("BossAuth", "YuceSamet", new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Expires = System.DateTimeOffset.Now.AddHours(2),
                    HttpOnly = true
                });
                return RedirectToAction("Settings");
            }
            
            TempData["BossError"] = "Şifre Yanlış! Sen Yüce Kurucu Değilsin!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BossLogout()
        {
            Response.Cookies.Delete("BossAuth");
            return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Settings()
        {
            if (Request.Cookies["BossAuth"] != "YuceSamet")
            {
                return RedirectToAction("Index");
            }

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7184/api/DeveloperSettings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<UpdateDeveloperSettingDto>>(jsonData);
                return View(values?.FirstOrDefault());
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Settings(UpdateDeveloperSettingDto updateDeveloperSettingDto)
        {
            if (Request.Cookies["BossAuth"] != "YuceSamet")
            {
                return RedirectToAction("Index");
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateDeveloperSettingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7184/api/DeveloperSettings", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Settings", "DeveloperSetting", new { area = "Admin" });
            }
            return View();
        }
    }
}
