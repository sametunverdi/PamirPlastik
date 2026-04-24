using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int CategoryID { get; set; } // Kategorinin eşsiz kimliği
        public string Name_TR { get; set; } // Kategorinin Türkçe adı
        public string Name_EN { get; set; } // Kategorinin İngilizce adı
        public string Description_TR { get; set; } // Kategori kısa açıklaması (TR)
        public string Description_EN { get; set; } // Kategori kısa açıklaması (EN)
        public string ImageUrl { get; set; } // Kategori kapak görseli yolu
        public string Slug { get; set; } // URL dostu isim (Örn: mutfak-gerecleri)
        public bool Status { get; set; } // Aktif/Pasif durumu
        public int ProductCount { get; set; }
    }
}
