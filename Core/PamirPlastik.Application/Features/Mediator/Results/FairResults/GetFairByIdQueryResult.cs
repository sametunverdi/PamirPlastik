using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.FairResults
{
    public class GetFairByIdQueryResult
    {
        public int FairID { get; set; }
        public string Name_TR { get; set; }
        public string Description_TR { get; set; }
        public string ImageAlt_TR { get; set; }
        public string Name_EN { get; set; }
        public string Description_EN { get; set; }
        public string ImageAlt_EN { get; set; }
        public string Location { get; set; }
        public string StandNo { get; set; }
        public DateTime FairDate { get; set; }
        public string ImagePath1 { get; set; }
        public string ImagePath2 { get; set; }
        public bool IsActive { get; set; }
    }
}
