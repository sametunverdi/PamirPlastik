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
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                Name_TR = request.Name_TR,
                ShortDescription_TR = request.ShortDescription_TR,
                Description_TR = request.Description_TR,
                Name_EN = request.Name_EN,
                ShortDescription_EN = request.ShortDescription_EN,
                Description_EN = request.Description_EN,
                ProductCode = request.ProductCode,
                ImagePath = request.ImagePath,
                ImageAlt_TR = request.ImageAlt_TR,
                ImageAlt_EN = request.ImageAlt_EN,
                Slug = request.Slug,
                Material = request.Material,
                BoxDimensions = request.BoxDimensions,
                BoxWeight = request.BoxWeight,
                LoadingCapacity = request.LoadingCapacity,
                BoxQuantity = request.BoxQuantity,
                IsFeatured = request.IsFeatured,
                IsActive = request.IsActive,
                Order = request.Order,
                MetaTitle_TR = request.MetaTitle_TR,
                MetaTitle_EN = request.MetaTitle_EN,
                MetaDescription_TR = request.MetaDescription_TR,
                MetaDescription_EN = request.MetaDescription_EN,
                CategoryID = request.CategoryID
            });
        }
    }
}