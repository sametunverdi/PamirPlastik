using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands
{
    public class UpdateProductImageCommand : IRequest
    {
        public int ProductImageID { get; set; } // Hangi resmi güncelliyoruz?
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }
    }
}
