using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Xml;

namespace PamirPlastik.WebUI.Controllers
{
    public class SitemapController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SitemapController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("sitemap.xml")]
        public async Task<IActionResult> Index()
        {
            var baseUrl = "https://www.pamirplastik.com";
            var client = _httpClientFactory.CreateClient();

            var xmlBuilder = new StringBuilder();
            xmlBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            xmlBuilder.AppendLine("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\" xmlns:xhtml=\"http://www.w3.org/1999/xhtml\">");

            // Ana sayfalar
            var staticPages = new[] { "", "/About", "/Category", "/Fair", "/Contact" };
            foreach (var page in staticPages)
            {
                xmlBuilder.AppendLine("  <url>");
                xmlBuilder.AppendLine($"    <loc>{baseUrl}{page}</loc>");
                xmlBuilder.AppendLine("    <changefreq>weekly</changefreq>");
                xmlBuilder.AppendLine("    <priority>" + (page == "" ? "1.0" : "0.8") + "</priority>");
                if(page == "")
                {
                    xmlBuilder.AppendLine($"    <xhtml:link rel=\"alternate\" hreflang=\"en\" href=\"{baseUrl}/?lang=en\" />");
                    xmlBuilder.AppendLine($"    <xhtml:link rel=\"alternate\" hreflang=\"tr\" href=\"{baseUrl}/?lang=tr\" />");
                }
                xmlBuilder.AppendLine("  </url>");
            }

            // Dinamik Ürünleri Çek
            try
            {
                var response = await client.GetAsync("https://localhost:7184/api/Products");
                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);
                    
                    if (products != null)
                    {
                        foreach (var prod in products)
                        {
                            string slug = prod.Slug_TR; // Assuming your API returns a slug, else we use ID
                            if (!string.IsNullOrEmpty(slug))
                            {
                                xmlBuilder.AppendLine("  <url>");
                                xmlBuilder.AppendLine($"    <loc>{baseUrl}/urun/{slug}</loc>");
                                xmlBuilder.AppendLine("    <changefreq>weekly</changefreq>");
                                xmlBuilder.AppendLine("    <priority>0.9</priority>");
                                xmlBuilder.AppendLine("  </url>");
                            }
                        }
                    }
                }
            }
            catch { /* Hata olursa sitemap'in çökmesini engelle, sadece statikleri ver */ }

            xmlBuilder.AppendLine("</urlset>");

            return Content(xmlBuilder.ToString(), "application/xml", Encoding.UTF8);
        }
    }
}