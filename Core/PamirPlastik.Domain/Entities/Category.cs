using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Domain.Entities
{
    public class Category
    {
        public int CategoryID { get; set; } // Birincil anahtar

        // SEO ve Dil Desteği
        public string? Name_TR { get; set; } // Kategorinin Türkçe adı
        public string? Name_EN { get; set; } // Kategorinin İngilizce adı

        public string? Description_TR { get; set; } // Kartlarda görünen kısa Türkçe açıklama
        public string? Description_EN { get; set; } // Kartlarda görünen kısa İngilizce açıklama

        public string? ImageUrl { get; set; } // Kategorinin kapak fotoğrafı yolu

        public string? Slug { get; set; } // URL dostu isim

        public bool Status { get; set; } // Kategori yayında mı?
        public bool ShowOnHome { get; set; } // Ana sayfada gösterilsin mi?

        // İlişki (Navigation Property)
        public List<Product>? Products { get; set; }
    }
}
