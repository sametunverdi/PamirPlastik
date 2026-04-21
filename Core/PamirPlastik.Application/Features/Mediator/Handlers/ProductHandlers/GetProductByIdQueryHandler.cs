using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IRepository<Product> _repository;

        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetProductByIdQueryResult
            {
                ProductID = value.ProductID,
                Name_TR = value.Name_TR,
                ShortDescription_TR = value.ShortDescription_TR,
                Description_TR = value.Description_TR,
                Name_EN = value.Name_EN,
                ShortDescription_EN = value.ShortDescription_EN,
                Description_EN = value.Description_EN,
                ProductCode = value.ProductCode,
                ImagePath = value.ImagePath,
                ImageAlt_TR = value.ImageAlt_TR,
                ImageAlt_EN = value.ImageAlt_EN,
                Slug = value.Slug,
                Material = value.Material,
                BoxDimensions = value.BoxDimensions,
                BoxWeight = value.BoxWeight,
                LoadingCapacity = value.LoadingCapacity,
                BoxQuantity = value.BoxQuantity,
                IsFeatured = value.IsFeatured,
                IsActive = value.IsActive,
                Order = value.Order,
                MetaTitle_TR = value.MetaTitle_TR,
                MetaTitle_EN = value.MetaTitle_EN,
                MetaDescription_TR = value.MetaDescription_TR,
                MetaDescription_EN = value.MetaDescription_EN,
                CategoryID = value.CategoryID
            };
        }
    }
}