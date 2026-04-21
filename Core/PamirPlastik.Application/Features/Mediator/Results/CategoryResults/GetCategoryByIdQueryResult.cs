using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Results.CategoryResults
{
    public class GetCategoryByIdQueryResult
    {
        public int CategoryID { get; set; }

        public string Name_TR { get; set; }
        public string Description_TR { get; set; }
        public string Name_EN { get; set; }
        public string Description_EN { get; set; }

        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }
        public string Slug { get; set; }

        public int Order { get; set; }
        public bool IsActive { get; set; }
        public string MetaTitle_TR { get; set; }
        public string MetaTitle_EN { get; set; }
        public string MetaDescription_TR { get; set; }
        public string MetaDescription_EN { get; set; }
    }
}
