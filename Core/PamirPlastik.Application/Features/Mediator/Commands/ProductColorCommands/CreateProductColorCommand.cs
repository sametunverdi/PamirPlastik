using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ProductColorCommands
{
    public class CreateProductColorCommand : IRequest
    {
        public string ColorName_TR { get; set; }
        public string ColorName_EN { get; set; }
        public string ColorHex { get; set; }
        public int ProductID { get; set; }
    }
}
