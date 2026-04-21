using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.TrendyolSettingCommands
{
    public class UpdateTrendyolSettingCommand : IRequest
    {
        public int TrendyolSettingID { get; set; }
        public string StoreUrl { get; set; }
        public string Rating { get; set; }
        public string MonthlyDelivery { get; set; }
        public string ReviewCount { get; set; }
    }
}
