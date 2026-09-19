using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using PamirPlastik.Application.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductBySlugQueryHandler : IRequestHandler<GetProductBySlugQuery, GetProductBySlugQueryResult>
    {
        private readonly IProductRepository _repository;

        public GetProductBySlugQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetProductBySlugQueryResult> Handle(GetProductBySlugQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetProductBySlugAsync(request.Slug);

            if (value == null) return null;

            return new GetProductBySlugQueryResult
            {
                ProductID = value.ProductID,
                Name_TR = value.Name_TR,
                Name_EN = value.Name_EN,
                Slug_TR = value.Slug_TR,
                Slug_EN = value.Slug_EN,
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
                Colors = value.ProductColors?.Select(c => new ResultProductColorDto
                {
                    ColorID = c.Color?.ColorID ?? 0,
                    Name_TR = c.Color?.Name_TR,
                    Name_EN = c.Color?.Name_EN,
                    HexCode = c.Color?.HexCode
                }).ToList(),
                Images = value.ProductImages?.Select(i => new ResultProductImageDto
                {
                    ProductImageID = i.ProductImageID,
                    ImageUrl = i.ImageUrl
                }).ToList()
            };
        }
    }
}
