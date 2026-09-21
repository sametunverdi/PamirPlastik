using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; } // Birincil anahtar

        // Dil Desteği Gerektiren Alanlar
        public string? Name_TR { get; set; } // Ürün adı Türkçe (Örn: Premium Süzgeç Seti)
        public string? Name_EN { get; set; } // Ürün adı İngilizce
        public string? ShortDescription_TR { get; set; } // Katalog kartındaki 2 satırlık açıklama (TR)
        public string? ShortDescription_EN { get; set; } // Katalog kartındaki 2 satırlık açıklama (EN)
        public string? FullDescription_TR { get; set; } // Detay sayfasındaki uzun üretim standartları metni (TR)
        public string? FullDescription_EN { get; set; } // Detay sayfasındaki uzun üretim standartları metni (EN)
        public string? Slug_TR { get; set; } // SEO Url (TR)
        public string? Slug_EN { get; set; } // SEO Url (EN)

        // Teknik ve Lojistik Veriler (Bunlar sayısal/sabit olduğu için dil fark etmez)
        public string? ProductCode { get; set; } // Ürün Kodu (Örn: PMR-402)
        public int BoxCount { get; set; } // Koli Adedi (Örn: 48)
        public string? Capacity { get; set; } // Hacim Kapasitesi (Örn: 2.5 Litre)
        public string? Material { get; set; } // Hammadde (Örn: Orijinal PP)
        public string? BoxSize { get; set; } // Koli Ölçüsü (Örn: 60x40x40 cm)
        public string? BoxWeight { get; set; } // Koli Ağırlığı (Örn: 12.4 Kg)

        // Özellikler (Boolean)
        public bool IsDishwasherSafe { get; set; } // Bulaşık makinesinde yıkanabilir mi?
        public bool IsFoodSafe { get; set; } // Gıda temasına uygun mu?

        // Vitrin ve Durum Yönetimi
        public string? MainImageUrl { get; set; } // Katalog listesinde görünecek ana kapak resmi
        public bool IsFeatured { get; set; } // Senin istediğin "Yıldızlı Ürün". True ise ana sayfaya düşer.
        public bool Status { get; set; } // Ürün yayında mı?
        public int Order { get; set; } // Ürünlerin sıralaması (Örn: en çok satan en üstte)

        // İlişkiler (Navigation Properties)
        public int CategoryID { get; set; } // Hangi kategoriye bağlı olduğunu tutan Id
        public Category Category { get; set; } // Ürünün kategorisine erişim yolu

        public List<ProductImage>? ProductImages { get; set; } // Ürünün galerisindeki diğer resimler (1'e Çok İlişki)
        public List<ProductColor>? ProductColors { get; set; }
    }
}
