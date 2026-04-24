using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ProductImageResults
{
    public class GetProductImageByIdQueryResult
    {
        public int ProductImageID { get; set; }
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }
    }
}
