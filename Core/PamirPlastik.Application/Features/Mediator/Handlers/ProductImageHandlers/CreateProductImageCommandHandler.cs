using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
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
                ImagePath = request.ImagePath,
                ImageAlt_TR = request.ImageAlt_TR,
                ImageAlt_EN = request.ImageAlt_EN,
                IsMain = request.IsMain,
                Order = request.Order,
                ProductID = request.ProductID
            });
        }
    }
}