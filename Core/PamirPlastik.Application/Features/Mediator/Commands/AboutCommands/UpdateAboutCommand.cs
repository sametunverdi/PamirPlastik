using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.AboutCommands
{
    public class UpdateAboutCommand : IRequest
    {
        public int AboutID { get; set; }
        public string StoryTitle_TR { get; set; }
        public string StoryTitle_EN { get; set; }
        public string StorySubtitle_TR { get; set; }
        public string StorySubtitle_EN { get; set; }
        public string StoryParagraph1_TR { get; set; }
        public string StoryParagraph1_EN { get; set; }
        public string StoryParagraph2_TR { get; set; }
        public string StoryParagraph2_EN { get; set; }
        public string StoryQuote_TR { get; set; }
        public string StoryQuote_EN { get; set; }
        public string StoryParagraph3_TR { get; set; }
        public string StoryParagraph3_EN { get; set; }
        public string FacilitySectionBadge_TR { get; set; }
        public string FacilitySectionBadge_EN { get; set; }
        public string FacilitySectionTitle_TR { get; set; }
        public string FacilitySectionTitle_EN { get; set; }
        public string Stat1Value { get; set; }
        public string Stat1Label_TR { get; set; }
        public string Stat1Label_EN { get; set; }
        public string Stat2Value { get; set; }
        public string Stat2Label_TR { get; set; }
        public string Stat2Label_EN { get; set; }
        public string VisionBadge_TR { get; set; }
        public string VisionBadge_EN { get; set; }
        public string VisionText_TR { get; set; }
        public string VisionText_EN { get; set; }
        public string VisionSubText_TR { get; set; }
        public string VisionSubText_EN { get; set; }
        public string MissionBadge_TR { get; set; }
        public string MissionBadge_EN { get; set; }
        public string MissionText_TR { get; set; }
        public string MissionText_EN { get; set; }
        public string MissionSubText_TR { get; set; }
        public string MissionSubText_EN { get; set; }
        public string CtaTitle_TR { get; set; }
        public string CtaTitle_EN { get; set; }
        public string CtaSubText_TR { get; set; }
        public string CtaSubText_EN { get; set; }
        public string MetaTitle_TR { get; set; }
        public string MetaTitle_EN { get; set; }
        public string MetaDescription_TR { get; set; }
        public string MetaDescription_EN { get; set; }
    }
}
