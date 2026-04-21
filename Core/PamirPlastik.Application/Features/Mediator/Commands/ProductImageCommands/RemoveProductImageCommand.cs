using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands
{
    public class RemoveProductImageCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveProductImageCommand(int id)
        {
            Id = id;
        }
    }
}
