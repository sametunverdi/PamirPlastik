using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ProductColorResults
{
    public class GetProductColorQueryResult
    {
        public int ProductColorID { get; set; }
        public string ColorName_TR { get; set; }
        public string ColorName_EN { get; set; }
        public string ColorHex { get; set; }
        public int ProductID { get; set; }
    }
}
