using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class AboutImage
    {
        public int Id { get; set; }

        // Ýliþki
        public int AboutId { get; set; }
        public About About { get; set; }

        // HTML'deki: <img src="..."> kýsmýna basýlacak URL
        public string? ImageUrl { get; set; }

        // HTML'deki: alt="..." kýsmý. SEO için çok önemli! Görme engelliler ve Google botlarý okur.
        public string? AltText_TR { get; set; }
        public string? AltText_EN { get; set; }

        // Slider'da hangi sýrayla çýksýn?
        public int Order { get; set; }
    }
}
