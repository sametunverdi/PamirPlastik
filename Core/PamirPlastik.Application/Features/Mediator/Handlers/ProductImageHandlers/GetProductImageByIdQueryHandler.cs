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
    public class GetProductImageByIdQueryHandler : IRequestHandler<GetProductImageByIdQuery, GetProductImageByIdQueryResult>
    {
        private readonly IRepository<ProductImage> _repository;

        public GetProductImageByIdQueryHandler(IRepository<ProductImage> repository)
        {
            _repository = repository;
        }

        public async Task<GetProductImageByIdQueryResult> Handle(GetProductImageByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetProductImageByIdQueryResult
            {
                ProductImageID = value.ProductImageID,
                ImageUrl = value.ImageUrl,
                ProductID = value.ProductID
            };
        }
    }
}
