using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.HeroStatResults
{
    public class GetHeroStatByIdQueryResult
    {
        public int HeroStatID { get; set; }
        public string Value { get; set; }
        public string Label_TR { get; set; }
        public string Label_EN { get; set; }
        public bool IsActive { get; set; }
    }
}
