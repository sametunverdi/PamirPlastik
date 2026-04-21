using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.SeoSettingCommands
{
    public class CreateSeoSettingCommand : IRequest
    {
        public string PageName { get; set; }
        public string MetaTitle_TR { get; set; }
        public string MetaDescription_TR { get; set; }
        public string MetaTitle_EN { get; set; }
        public string MetaDescription_EN { get; set; }
    }
}

