using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ProductColorCommands
{
    public class RemoveProductColorCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductColorCommand(int id)
        {
            Id = id;
        }
    }
}
