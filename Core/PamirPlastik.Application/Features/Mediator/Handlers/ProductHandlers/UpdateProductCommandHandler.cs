using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductCommands;
using PamirPlastik.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _repository;
        public UpdateProductCommandHandler(IProductRepository repository) { _repository = repository; }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ProductID);
            if (value != null)
            {
                value.Name_TR = request.Name_TR;
                value.Name_EN = request.Name_EN;
                value.Slug_TR = request.Slug_TR;
                value.Slug_EN = request.Slug_EN;
                value.ShortDescription_TR = request.ShortDescription_TR;
                value.ShortDescription_EN = request.ShortDescription_EN;
                value.FullDescription_TR = request.FullDescription_TR;
                value.FullDescription_EN = request.FullDescription_EN;
                value.ProductCode = request.ProductCode;
                value.BoxCount = request.BoxCount;
                value.Capacity = request.Capacity;
                value.Material = request.Material;
                value.BoxSize = request.BoxSize;
                value.BoxWeight = request.BoxWeight;
                value.IsDishwasherSafe = request.IsDishwasherSafe;
                value.IsFoodSafe = request.IsFoodSafe;
                value.MainImageUrl = request.MainImageUrl;
                value.IsFeatured = request.IsFeatured;
                value.Status = request.Status;
                value.Order = request.Order;
                value.CategoryID = request.CategoryId;
                await _repository.UpdateAsync(value);
            }
        }
    }
}