using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        // TR
        public string Name_TR { get; set; }
        public string ShortDescription_TR { get; set; }
        public string Description_TR { get; set; }

        // EN
        public string Name_EN { get; set; }
        public string ShortDescription_EN { get; set; }
        public string Description_EN { get; set; }

        // Ürün Kodu
        public string ProductCode { get; set; }

        // Görsel
        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }

        // URL
        public string Slug { get; set; }

        // Lojistik
        public string Material { get; set; }
        public string BoxDimensions { get; set; }
        public string BoxWeight { get; set; }
        public string LoadingCapacity { get; set; }
        public string BoxQuantity { get; set; }

        // Durum
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }
        public int Order { get; set; }

        // SEO
        public string MetaTitle_TR { get; set; }
        public string MetaTitle_EN { get; set; }
        public string MetaDescription_TR { get; set; }
        public string MetaDescription_EN { get; set; }

        // İlişkiler
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }
    }
}
