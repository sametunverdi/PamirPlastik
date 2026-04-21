using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.TrendyolSettingCommands
{
    public class RemoveTrendyolSettingCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveTrendyolSettingCommand(int id)
        {
            Id = id;
        }
    }
}
