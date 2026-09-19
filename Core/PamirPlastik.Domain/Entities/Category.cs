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

        // SEO ve Dil Desteði
        public string? Name_TR { get; set; } // Kategorinin Türkçe adý (Örn: Mutfak Gereçleri)
        public string? Name_EN { get; set; } // Kategorinin Ýngilizce adý (Örn: Kitchenware)

        public string? Description_TR { get; set; } // Kartlarda görünen kýsa Türkçe açýklama
        public string? Description_EN { get; set; } // Kartlarda görünen kýsa Ýngilizce açýklama

        public string? ImageUrl { get; set; } // Kategorinin kapak fotoðrafý yolu

        public string? Slug { get; set; } // URL dostu isim (Örn: mutfak-gerecleri). SEO için kritik!

        public bool Status { get; set; } // Kategori yayýnda mý? (true/false)

        // Ýliþki (Navigation Property)
        // Bir kategorinin birden fazla ürünü olabilir.
        public List<Product> Products { get; set; }
    }
}
