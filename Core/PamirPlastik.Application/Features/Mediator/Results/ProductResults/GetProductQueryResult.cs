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
        public string ProductCode { get; set; }
        public string ImagePath { get; set; }
        public string Slug { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }
        public int CategoryID { get; set; }
    }
}
