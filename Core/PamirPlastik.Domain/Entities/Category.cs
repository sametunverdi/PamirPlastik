using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }

        // TR
        public string Name_TR { get; set; }
        public string Description_TR { get; set; }

        // EN
        public string Name_EN { get; set; }
        public string Description_EN { get; set; }

        // Görsel
        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }

        // URL (örn: "mutfak-gerecleri")
        public string Slug { get; set; }

        // Sıralama & Durum
        public int Order { get; set; }
        public bool IsActive { get; set; }

        // SEO
        public string MetaTitle_TR { get; set; }
        public string MetaTitle_EN { get; set; }
        public string MetaDescription_TR { get; set; }
        public string MetaDescription_EN { get; set; }

        // Navigation Property
        public ICollection<Product> Products { get; set; }
    }
}
