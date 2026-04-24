using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.CategoryQueries;
using PamirPlastik.Application.Features.Mediator.Results.CategoryResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryQueryHandler(IRepository<Category> repository) { _repository = repository; }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                Name_TR = x.Name_TR,
                Name_EN = x.Name_EN,
                Description_TR = x.Description_TR,
                Description_EN = x.Description_EN,
                ImageUrl = x.ImageUrl,
                Slug = x.Slug,
                Status = x.Status,
                ProductCount = x.Products != null ? x.Products.Count() : 0
            }).ToList();
        }
    }
}
