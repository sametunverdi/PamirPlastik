using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ProductID);
            if (value != null)
            {
                value.Name_TR = request.Name_TR;
                value.ShortDescription_TR = request.ShortDescription_TR;
                value.Description_TR = request.Description_TR;
                value.Name_EN = request.Name_EN;
                value.ShortDescription_EN = request.ShortDescription_EN;
                value.Description_EN = request.Description_EN;
                value.ProductCode = request.ProductCode;
                value.ImagePath = request.ImagePath;
                value.ImageAlt_TR = request.ImageAlt_TR;
                value.ImageAlt_EN = request.ImageAlt_EN;
                value.Slug = request.Slug;
                value.Material = request.Material;
                value.BoxDimensions = request.BoxDimensions;
                value.BoxWeight = request.BoxWeight;
                value.LoadingCapacity = request.LoadingCapacity;
                value.BoxQuantity = request.BoxQuantity;
                value.IsFeatured = request.IsFeatured;
                value.IsActive = request.IsActive;
                value.Order = request.Order;
                value.MetaTitle_TR = request.MetaTitle_TR;
                value.MetaTitle_EN = request.MetaTitle_EN;
                value.MetaDescription_TR = request.MetaDescription_TR;
                value.MetaDescription_EN = request.MetaDescription_EN;
                value.CategoryID = request.CategoryID;

                await _repository.UpdateAsync(value);
            }
        }
    }
}