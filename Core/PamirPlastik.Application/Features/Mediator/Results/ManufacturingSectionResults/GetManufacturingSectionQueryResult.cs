using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ManufacturingSectionResults
{
    public class GetManufacturingSectionQueryResult
    {
        public int ManufacturingSectionID { get; set; }
        public string SubTitle_TR { get; set; }
        public string TitleMain_TR { get; set; }
        public string TitleHighlight_TR { get; set; }
        public string Description_TR { get; set; }
        public string ButtonText_TR { get; set; }
        public string SubTitle_EN { get; set; }
        public string TitleMain_EN { get; set; }
        public string TitleHighlight_EN { get; set; }
        public string Description_EN { get; set; }
        public string ButtonText_EN { get; set; }
        public string ButtonUrl { get; set; }
        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }
        public string StatValue { get; set; }
        public string StatLabel_TR { get; set; }
        public string StatLabel_EN { get; set; }
        public bool IsActive { get; set; }
    }
}
