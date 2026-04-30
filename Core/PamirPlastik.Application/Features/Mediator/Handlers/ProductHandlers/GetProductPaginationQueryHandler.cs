using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductPaginationQueryHandler : IRequestHandler<GetProductPaginationQuery, List<GetProductQueryResult>>
    {
        private readonly IRepository<Product> _repository;

        public GetProductPaginationQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductPaginationQuery request, CancellationToken cancellationToken)
        {
            var allValues = await _repository.GetAllAsync();


            var filteredValues = request.CategoryID.HasValue
                ? allValues.Where(x => x.CategoryID == request.CategoryID.Value).ToList()
                : allValues.ToList();

            var values = filteredValues
                .OrderBy(x => x.ProductID)
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();

            return values.Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Name_TR = x.Name_TR,
                Name_EN = x.Name_EN,
                ShortDescription_TR = x.ShortDescription_TR,
                ShortDescription_EN = x.ShortDescription_EN,
                MainImageUrl = x.MainImageUrl,
                ProductCode = x.ProductCode,
                IsFeatured = x.IsFeatured,
                CategoryName = x.Category != null ? x.Category.Name_TR : "Pamir Plastik"
            }).ToList();
        }
    }
}