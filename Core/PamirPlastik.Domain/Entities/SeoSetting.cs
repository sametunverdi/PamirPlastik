using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class SeoSetting
    {
        public int SeoSettingID { get; set; }

        public string PageName { get; set; }
        // Hangi sayfa → "HomePage", "AboutPage", "ContactPage", "FairsPage"

        // ── TR ───────────────────────────────────────
        public string MetaTitle_TR { get; set; }
        // "Pamir Plastik | Kaliteli Plastik Ürünler"

        public string MetaDescription_TR { get; set; }
        // "25 yıllık tecrübemizle..."

        // ── EN ───────────────────────────────────────
        public string MetaTitle_EN { get; set; }
        // "Pamir Plastik | Quality Plastic Products"

        public string MetaDescription_EN { get; set; }
        // "With 25 years of experience..."
    }
}
