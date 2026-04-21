using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.HeroSectionCommands
{
    public class RemoveHeroSectionCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveHeroSectionCommand(int id)
        {
            Id = id;
        }
    }
}
