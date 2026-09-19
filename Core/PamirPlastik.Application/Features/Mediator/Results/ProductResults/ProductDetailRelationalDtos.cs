using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.ProductResults
{
    public class ResultProductColorDto
    {
        public int ColorID { get; set; }
        public string? Name_TR { get; set; }
        public string? Name_EN { get; set; }
        public string? HexCode { get; set; }
    }

    public class ResultProductImageDto
    {
        public int ProductImageID { get; set; }
        public string? ImageUrl { get; set; }
    }
}
