using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.FairCommands
{
    public class RemoveFairCommand : IRequest
    {
        public RemoveFairCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
