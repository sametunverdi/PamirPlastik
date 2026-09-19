using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class About
    {
        public int Id { get; set; }

        // --- SEO BÖLÜMÜ ---
        // HTML'deki: ViewData["Title"] ve ViewData["Description"] kýsýmlarý
        public string? SeoTitle_TR { get; set; }
        public string? SeoTitle_EN { get; set; }
        public string? SeoDescription_TR { get; set; }
        public string? SeoDescription_EN { get; set; }

        // --- HERO BÖLÜMÜ (En üstteki yazýlar) ---
        // HTML'deki: "1990'dan Bugüne, Her Enjeksiyonda Ayný Tutku."
        public string? MainTitle_TR { get; set; }
        public string? MainTitle_EN { get; set; }

        // HTML'deki: "Küçük bir atölyeden, dünyaya açýlan entegre tesislere..."
        public string? SubTitle_TR { get; set; }
        public string? SubTitle_EN { get; set; }

        // HTML'deki: "Pamir Plastik olarak yolculuðumuz..." diye baþlayan uzun metinler
        public string? Description1_TR { get; set; }
        public string? Description1_EN { get; set; }
        public string? Description2_TR { get; set; }
        public string? Description2_EN { get; set; }

        // HTML'deki: Sarý kutu içindeki "Sadece plastik üretmiyoruz..." yazýsý
        public string? HighlightQuote_TR { get; set; }
        public string? HighlightQuote_EN { get; set; }

        // --- VÝZYON VE MÝSYON BÖLÜMÜ ---
        // HTML'deki: "Gelecek Vizyonu" ve "Temel Misyon" alanlarý
        public string? VisionTitle_TR { get; set; }
        public string? VisionTitle_EN { get; set; }
        public string? VisionDescription_TR { get; set; }
        public string? VisionDescription_EN { get; set; }

        public string? MissionTitle_TR { get; set; }
        public string? MissionTitle_EN { get; set; }
        public string? MissionDescription_TR { get; set; }
        public string? MissionDescription_EN { get; set; }

        // --- ÝLÝÞKÝLER (Navigation Properties) ---
        // Entity Framework'e "Bu ana tablonun alt maddeleri ve resimleri var" diyoruz.
        public ICollection<AboutFeature> Features { get; set; }
        public ICollection<AboutImage> Images { get; set; }
    }
}
