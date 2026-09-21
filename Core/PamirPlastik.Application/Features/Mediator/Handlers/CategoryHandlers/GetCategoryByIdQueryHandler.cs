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
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryByIdQueryHandler(IRepository<Category> repository) { _repository = repository; }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = value.CategoryID,
                Name_TR = value.Name_TR,
                Name_EN = value.Name_EN,
                Description_TR = value.Description_TR,
                Description_EN = value.Description_EN,
                ImageUrl = value.ImageUrl,
                Slug = value.Slug,
                Status = value.Status,
                ShowOnHome = value.ShowOnHome
            };
        }
    }
}
