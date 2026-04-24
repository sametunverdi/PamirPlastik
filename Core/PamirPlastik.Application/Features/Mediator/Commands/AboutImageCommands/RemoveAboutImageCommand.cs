using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.AboutImageCommands
{
    public class RemoveAboutImageCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveAboutImageCommand(int id)
        {
            Id = id;
        }
    }
}
