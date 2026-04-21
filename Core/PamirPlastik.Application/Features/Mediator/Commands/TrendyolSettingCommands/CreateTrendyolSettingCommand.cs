using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.TrendyolSettingCommands
{
    public class CreateTrendyolSettingCommand : IRequest
    {
        public string StoreUrl { get; set; }
        public string Rating { get; set; }
        public string MonthlyDelivery { get; set; }
        public string ReviewCount { get; set; }
    }
}
