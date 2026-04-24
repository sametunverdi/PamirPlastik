using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.SocialMediaResults
{
    public class GetSocialMediaByIdQueryResult
    {
        public int SocialMediaID { get; set; }
        public string PlatformName { get; set; }
        public string IconClass { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}
