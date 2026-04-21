using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.AboutFeatureCommands
{
    public class RemoveAboutFeatureCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveAboutFeatureCommand(int id)
        {
            Id = id;
        }
    }
}
