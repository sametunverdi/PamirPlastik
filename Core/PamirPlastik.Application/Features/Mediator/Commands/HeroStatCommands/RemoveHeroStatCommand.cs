using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.HeroStatCommands
{
    public class RemoveHeroStatCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveHeroStatCommand(int id)
        {
            Id = id;
        }
    }
}
