using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class HeroSection
    {
        public int HeroSectionID { get; set; }

        // TR Alanlar
        public string BadgeText_TR { get; set; }
        public string TitleMain_TR { get; set; }
        public string TitleHighlight_TR { get; set; }
        public string TitleEnd_TR { get; set; }
        public string Description_TR { get; set; }
        public string PrimaryButtonText_TR { get; set; }
        public string SecondaryButtonText_TR { get; set; }

        // EN Alanlar
        public string BadgeText_EN { get; set; }
        public string TitleMain_EN { get; set; }
        public string TitleHighlight_EN { get; set; }
        public string TitleEnd_EN { get; set; }
        public string Description_EN { get; set; }
        public string PrimaryButtonText_EN { get; set; }
        public string SecondaryButtonText_EN { get; set; }

        // Dil Bağımsız
        public string PrimaryButtonUrl { get; set; }
        public string SecondaryButtonUrl { get; set; }
        public string ImagePath { get; set; }      // Görselin dosya yolu → "/images/hero.jpg"
        public string ImageAlt_TR { get; set; }    // Görselin TR alt etiketi (SEO)
        public string ImageAlt_EN { get; set; }    // Görselin EN alt etiketi (SEO)
        public bool IsActive { get; set; }

        // SEO
        public string MetaTitle_TR { get; set; }
        public string MetaTitle_EN { get; set; }
        public string MetaDescription_TR { get; set; }
        public string MetaDescription_EN { get; set; }
    }
}
