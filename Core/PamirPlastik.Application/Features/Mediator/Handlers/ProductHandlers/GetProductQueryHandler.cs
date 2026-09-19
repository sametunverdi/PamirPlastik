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
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IProductRepository _repository;
        public GetProductQueryHandler(IProductRepository repository) { _repository = repository; }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetProductsWithCategoryAsync();
            return values.OrderBy(x => x.Order).Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Name_TR = x.Name_TR,
                Name_EN = x.Name_EN,
                ShortDescription_TR = x.ShortDescription_TR,
                ShortDescription_EN = x.ShortDescription_EN,
                MainImageUrl = x.MainImageUrl,
                ProductCode = x.ProductCode,
                IsFeatured = x.IsFeatured,
                CategoryName = x.Category?.Name_TR
            }).ToList();
        }
    }
}