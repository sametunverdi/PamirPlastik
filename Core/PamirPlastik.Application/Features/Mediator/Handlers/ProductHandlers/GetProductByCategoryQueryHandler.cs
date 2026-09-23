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
    public class GetProductByCategoryQueryHandler : IRequestHandler<GetProductByCategoryQuery, List<GetProductQueryResult>>
    {
        private readonly IRepository<Product> _repository;

        public GetProductByCategoryQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductByCategoryQuery request, CancellationToken cancellationToken)
        {
            var allValues = await _repository.GetAllAsync();
            var values = allValues.Where(x => x.CategoryID == request.ID).OrderBy(x => x.Order).ToList();

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
                CategoryName = x.Category != null ? x.Category.Name_TR : "Kategorisiz",
                Slug_TR = x.Slug_TR,
                Slug_EN = x.Slug_EN
            }).ToList();
        }
    }
}
