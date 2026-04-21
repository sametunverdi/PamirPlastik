using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.AboutSliderImageCommands
{
    public class CreateAboutSliderImageCommand : IRequest
    {
        public string ImagePath { get; set; }
        public string ImageAlt_TR { get; set; }
        public string ImageAlt_EN { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public int AboutID { get; set; }
    }
}
