using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.HeroStatCommands
{
    public class CreateHeroStatCommand : IRequest
    {
        public string Value { get; set; }
        public string Label_TR { get; set; }
        public string Label_EN { get; set; }
        public bool IsActive { get; set; }
    }
}
