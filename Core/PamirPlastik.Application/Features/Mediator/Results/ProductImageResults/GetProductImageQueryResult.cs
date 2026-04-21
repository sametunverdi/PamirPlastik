using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ProductImageResults
{
    public class GetProductImageQueryResult
    {
        public int ProductImageID { get; set; }
        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }
        public bool IsMain { get; set; }
        public int Order { get; set; }
        public int ProductID { get; set; }
    }
}
