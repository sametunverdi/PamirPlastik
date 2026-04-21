using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ProductFeatureCommands
{
    public class RemoveProductFeatureCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductFeatureCommand(int id)
        {
            Id = id;
        }
    }
}
