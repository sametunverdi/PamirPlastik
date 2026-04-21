using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.HeroSectionCommands
{
    public class CreateHeroSectionCommand : IRequest
    {
        public string BadgeText_TR { get; set; }
        public string TitleMain_TR { get; set; }
        public string TitleHighlight_TR { get; set; }
        public string TitleEnd_TR { get; set; }
        public string Description_TR { get; set; }
        public string PrimaryButtonText_TR { get; set; }
        public string SecondaryButtonText_TR { get; set; }
        public string BadgeText_EN { get; set; }
        public string TitleMain_EN { get; set; }
        public string TitleHighlight_EN { get; set; }
        public string TitleEnd_EN { get; set; }
        public string Description_EN { get; set; }
        public string PrimaryButtonText_EN { get; set; }
        public string SecondaryButtonText_EN { get; set; }
        public string PrimaryButtonUrl { get; set; }
        public string SecondaryButtonUrl { get; set; }
        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }
        public bool IsActive { get; set; }
        public string MetaTitle_TR { get; set; }
        public string MetaTitle_EN { get; set; }
        public string MetaDescription_TR { get; set; }
        public string MetaDescription_EN { get; set; }
    }
}
