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
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Product> _productRepository; 

        public GetCategoryQueryHandler(IRepository<Category> categoryRepository, IRepository<Product> productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetAllAsync();
            var products = await _productRepository.GetAllAsync(); 

            return categories.Select(x => new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                Name_TR = x.Name_TR,
                Name_EN = x.Name_EN,
                Description_TR = x.Description_TR,
                Description_EN = x.Description_EN,
                ImageUrl = x.ImageUrl,
                Slug = x.Slug,
                Status = x.Status,
                ShowOnHome = x.ShowOnHome,
                ProductCount = products.Where(p => p.CategoryID == x.CategoryID).Count()
            }).ToList();
        }
    }
}
