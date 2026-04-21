using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ManufacturingSectionCommands
{
    public class RemoveManufacturingSectionCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveManufacturingSectionCommand(int id)
        {
            Id = id;
        }
    }
}
