using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ProductFeatureResults
{
    public class GetProductFeatureQueryResult
    {
        public int ProductFeatureID { get; set; }
        public string Feature_TR { get; set; }
        public string Feature_EN { get; set; }
        public int ProductID { get; set; }
    }
}
