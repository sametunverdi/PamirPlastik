using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PamirPlastik.WebUI.Controllers
{
    [Route("Language")]
    public class LanguageController : Controller
    {
        [HttpGet("Change")]
        public IActionResult Change(string culture, string returnUrl)
        {
            if (string.IsNullOrWhiteSpace(culture))
            {
                culture = "tr-TR";
            }

            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Redirect("/");
            }

            return LocalRedirect(returnUrl);
        }
    }
}
