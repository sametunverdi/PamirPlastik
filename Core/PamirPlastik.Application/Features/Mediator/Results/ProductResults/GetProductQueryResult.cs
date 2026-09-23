using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ProductResults
{
    public class GetProductQueryResult
    {
        public int ProductID { get; set; }
        public string Name_TR { get; set; }
        public string Name_EN { get; set; }
        public string ShortDescription_TR { get; set; }
        public string ShortDescription_EN { get; set; }
        public string MainImageUrl { get; set; } // Karttaki ana görsel
        public string ProductCode { get; set; } // PMR-402 gibi
        public bool IsFeatured { get; set; } // Yıldızlı mı?
        public bool Status { get; set; }
        public string CategoryName { get; set; }
        public string Slug_TR { get; set; }
        public string Slug_EN { get; set; } // UI'da "Mutfak" yazması için kategori adını da taşıyacağız
    }
}

