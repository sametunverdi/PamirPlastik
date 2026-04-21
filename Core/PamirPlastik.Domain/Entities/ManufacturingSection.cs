using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class ManufacturingSection
    {
        public int ManufacturingSectionID { get; set; }

        // ── TR ALANLAR ───────────────────────────────────────────
        public string SubTitle_TR { get; set; }       // Üst küçük yazı → "Neden Pamir Plastik?"
        public string TitleMain_TR { get; set; }      // Ana başlık → "Sadece Üretmiyor,"
        public string TitleHighlight_TR { get; set; } // Renkli kısım → "Değer Katıyoruz."
        public string Description_TR { get; set; }    // Açıklama paragrafı
        public string ButtonText_TR { get; set; }     // Buton yazısı → "Hakkımızda Daha Fazla"

        // ── EN ALANLAR ───────────────────────────────────────────
        public string SubTitle_EN { get; set; }       // "Why Pamir Plastik?"
        public string TitleMain_EN { get; set; }      // "We Don't Just Produce,"
        public string TitleHighlight_EN { get; set; } // "We Add Value."
        public string Description_EN { get; set; }    // Açıklama paragrafı EN
        public string ButtonText_EN { get; set; }     // "More About Us"

        // ── DİL BAĞIMSIZ ─────────────────────────────────────────
        public string ButtonUrl { get; set; }         // "/Corporate"
        public string ImagePath { get; set; }         // Sol görsel
        public string ImageAlt_TR { get; set; }       // Görsel TR alt (SEO)
        public string ImageAlt_EN { get; set; }       // Görsel EN alt (SEO)
        public string StatValue { get; set; }         // Görselin üstündeki sayı → "10 Milyon+"
        public string StatLabel_TR { get; set; }      // Sayının altı TR → "Yıllık Üretim Adedi"
        public string StatLabel_EN { get; set; }      // Sayının altı EN → "Annual Production"
        public bool IsActive { get; set; }
    }
}

