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

        // Hangi Hakkımızda sayfasına ait? (İlişki)
        public int AboutId { get; set; }
        public About About { get; set; }

        // Bu kayıt bir Üretim Aşaması mı (Process) yoksa İstatistik mi (Statistic)?
        // Bunu DTO'da filtrelerken kullanacağız (Örn: Sadece Process olanları sol tarafa diz)
        public string FeatureType { get; set; }

        // HTML'deki: "01", "02" veya istatistiklerdeki "10.000m²", "24/7" yazıları
        public string ValueOrIcon { get; set; }

        // HTML'deki: "Ar-Ge & Tasarım" veya "Kapalı Üretim Alanı"
        public string Title_TR { get; set; }
        public string Title_EN { get; set; }

        // HTML'deki: "Her ürün, kullanıcı ihtiyaçları doğrultusunda..."
        // İstatistikler için bu alan boş kalabilir (nullable yapabiliriz)
        public string Description_TR { get; set; }
        public string Description_EN { get; set; }

        // Sıralama için (Panelde hangisi önce görünsün istersen)
        public int Order { get; set; }
    }
}
