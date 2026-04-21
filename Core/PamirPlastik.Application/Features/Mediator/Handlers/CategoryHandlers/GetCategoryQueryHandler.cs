using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.CategoryQueries;
using PamirPlastik.Application.Features.Mediator.Results.CategoryResults;
using PamirPlastik.Application.Features.Mediator.Results.CategoryResults.PamirPlastik.Application.Features.Mediator.Results.CategoryResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                Name_TR = x.Name_TR,
                Description_TR = x.Description_TR,
                Name_EN = x.Name_EN,
                Description_EN = x.Description_EN,
                ImagePath = x.ImagePath,
                ImageAlt_TR = x.ImageAlt_TR,
                ImageAlt_EN = x.ImageAlt_EN,
                Slug = x.Slug,
                Order = x.Order,
                IsActive = x.IsActive,
                MetaTitle_TR = x.MetaTitle_TR,
                MetaTitle_EN = x.MetaTitle_EN,
                MetaDescription_TR = x.MetaDescription_TR,
                MetaDescription_EN = x.MetaDescription_EN
            }).ToList();
        }
    }
}