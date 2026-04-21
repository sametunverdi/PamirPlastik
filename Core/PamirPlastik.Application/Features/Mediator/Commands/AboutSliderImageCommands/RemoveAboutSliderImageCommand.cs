using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.AboutSliderImageCommands
{
    public class RemoveAboutSliderImageCommand : IRequest
    {
        public RemoveAboutSliderImageCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
