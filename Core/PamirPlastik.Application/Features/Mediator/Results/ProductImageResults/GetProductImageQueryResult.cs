using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ProductImageResults
{
    public class GetProductImageQueryResult
    {
        public int ProductImageID { get; set; } // Senin Entity'ndeki isim
        public string ImageUrl { get; set; }
        public int ProductID { get; set; } // Senin Entity'ndeki isim
    }
}
