using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.SeoSettingCommands
{
    public class RemoveSeoSettingCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveSeoSettingCommand(int id)
        {
            Id = id;
        }
    }
}
