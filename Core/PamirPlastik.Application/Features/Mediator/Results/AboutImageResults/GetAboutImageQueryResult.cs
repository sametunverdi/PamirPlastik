using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.AboutImageResults
{
    public class GetAboutImageQueryResult
    {
        public int Id { get; set; }
        public int AboutId { get; set; } // İlişkiyi tutan ID
        public string ImageUrl { get; set; }
        public string AltText_TR { get; set; }
        public string AltText_EN { get; set; }
        public int Order { get; set; }
    }
}
