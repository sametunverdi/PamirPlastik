using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.HeroStatCommands
{
    public class UpdateHeroStatCommand : IRequest
    {
        public int HeroStatID { get; set; }
        public string Value { get; set; }
        public string Label_TR { get; set; }
        public string Label_EN { get; set; }
        public bool IsActive { get; set; }
    }
}
