using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.AboutFeatureCommands
{
    public class UpdateAboutFeatureCommand : IRequest
    {
        public int AboutFeatureID { get; set; }
        public int Order { get; set; }
        public string Title_TR { get; set; }
        public string Title_EN { get; set; }
        public string Description_TR { get; set; }
        public string Description_EN { get; set; }
        public bool IsActive { get; set; }
        public int AboutID { get; set; }
    }
}
