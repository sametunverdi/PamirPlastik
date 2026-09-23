using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductPaginationQueryHandler : IRequestHandler<GetProductPaginationQuery, object>
    {
        private readonly IProductRepository _repository;

        public GetProductPaginationQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> Handle(GetProductPaginationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetProductsWithCategoryAsync();
            
            if (request.CategoryID.HasValue)
            {
                values = values.Where(x => x.CategoryID == request.CategoryID).ToList();
            }

            if (!string.IsNullOrEmpty(request.SearchQuery))
            {
                var query = request.SearchQuery.ToLowerInvariant();
                values = values.Where(x => 
                    (!string.IsNullOrEmpty(x.Name_TR) && x.Name_TR.ToLowerInvariant().Contains(query)) || 
                    (!string.IsNullOrEmpty(x.ProductCode) && x.ProductCode.ToLowerInvariant().Contains(query))
                ).ToList();
            }

            var totalCount = values.Count;
            var pagedValues = values.OrderBy(x => x.Order)
                                    .Skip((request.Page - 1) * request.PageSize)
                                    .Take(request.PageSize)
                                    .ToList();

            return new
            {
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize),
                CurrentPage = request.Page,
                Data = pagedValues.Select(x => new GetProductQueryResult
                {
                    ProductID = x.ProductID,
                    Name_TR = x.Name_TR,
                    Name_EN = x.Name_EN,
                    ShortDescription_TR = x.ShortDescription_TR,
                    ShortDescription_EN = x.ShortDescription_EN,
                    MainImageUrl = x.MainImageUrl,
                    ProductCode = x.ProductCode,
                    IsFeatured = x.IsFeatured,
                    Status = x.Status,
                    CategoryName = x.Category != null ? x.Category.Name_TR : "Pamir Plastik",
                    Slug_TR = x.Slug_TR,
                    Slug_EN = x.Slug_EN
                }).ToList()
            };
        }
    }
}
