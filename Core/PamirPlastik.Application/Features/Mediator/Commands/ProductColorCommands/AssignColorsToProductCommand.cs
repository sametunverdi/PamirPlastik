using MediatR;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Commands.ProductColorCommands
{
    public class AssignColorsToProductCommand : IRequest
    {
        public int ProductID { get; set; }
        public List<int>? ColorIDs { get; set; }
    }
}