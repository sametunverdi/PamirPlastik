using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.AboutImageCommands
{
    public class UpdateAboutImageCommand : IRequest
    {
        public int Id { get; set; }
        public int AboutId { get; set; }
        public string ImageUrl { get; set; }
        public string AltText_TR { get; set; }
        public string AltText_EN { get; set; }
        public int Order { get; set; }
    }
}
