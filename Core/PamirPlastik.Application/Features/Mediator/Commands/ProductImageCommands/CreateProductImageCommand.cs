using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands
{
    public class CreateProductImageCommand : IRequest
    {
        public string ImageUrl { get; set; }
        public int ProductID { get; set; } // Hangi ürüne resim ekliyoruz? İşte ilişki burada kanka!
    }
}
