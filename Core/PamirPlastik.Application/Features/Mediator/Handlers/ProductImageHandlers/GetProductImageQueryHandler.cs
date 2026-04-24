using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductImageQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductImageResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductImageHandlers
{
    public class GetProductImageQueryHandler : IRequestHandler<GetProductImageQuery, List<GetProductImageQueryResult>>
    {
        private readonly IRepository<ProductImage> _repository;

        public GetProductImageQueryHandler(IRepository<ProductImage> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductImageQueryResult>> Handle(GetProductImageQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductImageQueryResult
            {
                ProductImageID = x.ProductImageID,
                ImageUrl = x.ImageUrl,
                ProductID = x.ProductID
            }).ToList();
        }
    }
}
