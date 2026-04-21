using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ManufacturingFeatureCommands
{
    public class RemoveManufacturingFeatureCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveManufacturingFeatureCommand(int id)
        {
            Id = id;
        }
    }
}
