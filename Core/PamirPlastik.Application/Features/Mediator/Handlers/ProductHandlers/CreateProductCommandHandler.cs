using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepository _repository;
        public CreateProductCommandHandler(IProductRepository repository) { _repository = repository; }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name_TR = request.Name_TR,
                Name_EN = request.Name_EN,
                Slug_TR = request.Slug_TR,
                Slug_EN = request.Slug_EN,
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
                Order = request.Order,
                CategoryID = request.CategoryId
            };
            await _repository.CreateAsync(product);
            return product.ProductID;
        }
    }
}
