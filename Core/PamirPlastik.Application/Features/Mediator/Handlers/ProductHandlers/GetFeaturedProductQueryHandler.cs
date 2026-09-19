using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using PamirPlastik.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetFeaturedProductQueryHandler : IRequestHandler<GetFeaturedProductQuery, List<GetProductQueryResult>>
    {
        private readonly IProductRepository _repository;
        public GetFeaturedProductQueryHandler(IProductRepository repository) { _repository = repository; }

        public async Task<List<GetProductQueryResult>> Handle(GetFeaturedProductQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetFeaturedProductsWithCategoryAsync();
            return values.OrderBy(x => x.Order).Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Name_TR = x.Name_TR,
                Name_EN = x.Name_EN,
                MainImageUrl = x.MainImageUrl,
                ProductCode = x.ProductCode,
                IsFeatured = x.IsFeatured,
                CategoryName = x.Category?.Name_TR
            }).ToList();
        }
    }
}