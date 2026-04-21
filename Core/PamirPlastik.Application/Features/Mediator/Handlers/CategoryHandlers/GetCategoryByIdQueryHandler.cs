using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.CategoryQueries;
using PamirPlastik.Application.Features.Mediator.Results.CategoryResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetCategoryByIdQueryResult
            {
                CategoryID = value.CategoryID,
                Name_TR = value.Name_TR,
                Description_TR = value.Description_TR,
                Name_EN = value.Name_EN,
                Description_EN = value.Description_EN,
                ImagePath = value.ImagePath,
                ImageAlt_TR = value.ImageAlt_TR,
                ImageAlt_EN = value.ImageAlt_EN,
                Slug = value.Slug,
                Order = value.Order,
                IsActive = value.IsActive,
                MetaTitle_TR = value.MetaTitle_TR,
                MetaTitle_EN = value.MetaTitle_EN,
                MetaDescription_TR = value.MetaDescription_TR,
                MetaDescription_EN = value.MetaDescription_EN
            };
        }
    }
}