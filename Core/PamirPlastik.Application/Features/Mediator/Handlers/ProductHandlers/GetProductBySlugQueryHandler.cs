using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using PamirPlastik.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductBySlugQueryHandler : IRequestHandler<GetProductBySlugQuery, GetProductByIdQueryResult>
    {
        private readonly IProductRepository _repository;
        public GetProductBySlugQueryHandler(IProductRepository repository) { _repository = repository; }

        public async Task<GetProductByIdQueryResult> Handle(GetProductBySlugQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetProductBySlugAsync(request.Slug);
            if (value == null) return null;

            return new GetProductByIdQueryResult
            {
                ProductID = value.ProductID,
                Name_TR = value.Name_TR,
                Name_EN = value.Name_EN,
                ShortDescription_TR = value.ShortDescription_TR,
                ShortDescription_EN = value.ShortDescription_EN,
                FullDescription_TR = value.FullDescription_TR,
                FullDescription_EN = value.FullDescription_EN,
                ProductCode = value.ProductCode,
                BoxCount = value.BoxCount,
                Capacity = value.Capacity,
                Material = value.Material,
                BoxSize = value.BoxSize,
                BoxWeight = value.BoxWeight,
                IsDishwasherSafe = value.IsDishwasherSafe,
                IsFoodSafe = value.IsFoodSafe,
                MainImageUrl = value.MainImageUrl,
                IsFeatured = value.IsFeatured,
                Status = value.Status,
                CategoryId = value.CategoryID,
                CategoryName = value.Category?.Name_TR
            };
        }
    }
}
