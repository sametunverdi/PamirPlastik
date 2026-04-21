using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.HeroBadgeCommands
{
    public class UpdateHeroBadgeCommand : IRequest
    {
        public int HeroBadgeID { get; set; }
        public string Text_TR { get; set; }
        public string Text_EN { get; set; }
        public string IconName { get; set; }
        public bool IsActive { get; set; }
    }
}
