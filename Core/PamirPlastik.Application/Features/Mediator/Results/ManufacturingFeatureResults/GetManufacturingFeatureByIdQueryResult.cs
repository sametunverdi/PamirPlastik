using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ManufacturingFeatureResults
{
    public class GetManufacturingFeatureByIdQueryResult
    {
        public int ManufacturingFeatureID { get; set; }
        public string Title_TR { get; set; }
        public string Description_TR { get; set; }
        public string Title_EN { get; set; }
        public string Description_EN { get; set; }
        public string IconName { get; set; }
        public bool IsActive { get; set; }
    }
}
