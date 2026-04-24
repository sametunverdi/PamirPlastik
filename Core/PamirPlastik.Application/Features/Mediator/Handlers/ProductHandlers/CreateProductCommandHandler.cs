using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IProductRepository _repository;
        public CreateProductCommandHandler(IProductRepository repository) { _repository = repository; }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                Name_TR = request.Name_TR,
                Name_EN = request.Name_EN,
                ShortDescription_TR = request.ShortDescription_TR,
                ShortDescription_EN = request.ShortDescription_EN,
                FullDescription_TR = request.FullDescription_TR,
                FullDescription_EN = request.FullDescription_EN,
                ProductCode = request.ProductCode,
                BoxCount = request.BoxCount,
                Capacity = request.Capacity,
                Material = request.Material,
                BoxSize = request.BoxSize,
                BoxWeight = request.BoxWeight,
                IsDishwasherSafe = request.IsDishwasherSafe,
                IsFoodSafe = request.IsFoodSafe,
                MainImageUrl = request.MainImageUrl,
                IsFeatured = request.IsFeatured,
                Status = request.Status,
                CategoryID = request.CategoryId
            });
        }
    }
}