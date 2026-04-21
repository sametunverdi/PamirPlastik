using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ProductCommands
{
    public class UpdateProductCommand : IRequest
    {
        public int ProductID { get; set; }
        public string Name_TR { get; set; }
        public string ShortDescription_TR { get; set; }
        public string Description_TR { get; set; }
        public string Name_EN { get; set; }
        public string ShortDescription_EN { get; set; }
        public string Description_EN { get; set; }
        public string ProductCode { get; set; }
        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }
        public string Slug { get; set; }
        public string Material { get; set; }
        public string BoxDimensions { get; set; }
        public string BoxWeight { get; set; }
        public string LoadingCapacity { get; set; }
        public string BoxQuantity { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }
        public int Order { get; set; }
        public string MetaTitle_TR { get; set; }
        public string MetaTitle_EN { get; set; }
        public string MetaDescription_TR { get; set; }
        public string MetaDescription_EN { get; set; }
        public int CategoryID { get; set; }
    }
}
