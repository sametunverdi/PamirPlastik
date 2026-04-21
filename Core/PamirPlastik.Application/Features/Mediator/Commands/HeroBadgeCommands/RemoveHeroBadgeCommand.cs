using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.HeroBadgeCommands
{
    public class RemoveHeroBadgeCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveHeroBadgeCommand(int id)
        {
            Id = id;
        }
    }
}
