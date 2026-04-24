using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductImageHandlers
{
    public class CreateProductImageCommandHandler : IRequestHandler<CreateProductImageCommand>
    {
        private readonly IRepository<ProductImage> _repository;

        public CreateProductImageCommandHandler(IRepository<ProductImage> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductImageCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ProductImage
            {
                ImageUrl = request.ImageUrl,
                ProductID = request.ProductID
            });
        }
    }
}
