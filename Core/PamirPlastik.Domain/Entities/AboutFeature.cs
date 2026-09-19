using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class AboutFeature
    {
        public int Id { get; set; }

        // Hangi Hakkýmýzda sayfasýna ait? (Ýliþki)
        public int AboutId { get; set; }
        public About About { get; set; }

        // Bu kayýt bir Üretim Aþamasý mý (Process) yoksa Ýstatistik mi (Statistic)?
        // Bunu DTO'da filtrelerken kullanacaðýz (Örn: Sadece Process olanlarý sol tarafa diz)
        public string? FeatureType { get; set; }

        // HTML'deki: "01", "02" veya istatistiklerdeki "10.000m²", "24/7" yazýlarý
        public string? ValueOrIcon { get; set; }

        // HTML'deki: "Ar-Ge & Tasarým" veya "Kapalý Üretim Alaný"
        public string? Title_TR { get; set; }
        public string? Title_EN { get; set; }

        // HTML'deki: "Her ürün, kullanýcý ihtiyaçlarý doðrultusunda..."
        // Ýstatistikler için bu alan boþ kalabilir (nullable yapabiliriz)
        public string? Description_TR { get; set; }
        public string? Description_EN { get; set; }

        // Sýralama için (Panelde hangisi önce görünsün istersen)
        public int Order { get; set; }
    }
}
