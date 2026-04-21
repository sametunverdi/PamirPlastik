using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductImageQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductImageResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductImageHandlers
{
    public class GetProductImageByProductIdQueryHandler : IRequestHandler<GetProductImageByProductIdQuery, List<GetProductImageQueryResult>>
    {
        private readonly IRepository<ProductImage> _repository;
        public GetProductImageByProductIdQueryHandler(IRepository<ProductImage> repository) { _repository = repository; }

        public async Task<List<GetProductImageQueryResult>> Handle(GetProductImageByProductIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Where(x => x.ProductID == request.ProductID).Select(x => new GetProductImageQueryResult
            {
                ProductImageID = x.ProductImageID,
                ImagePath = x.ImagePath,
                ImageAlt_TR = x.ImageAlt_TR,
                ImageAlt_EN = x.ImageAlt_EN,
                IsMain = x.IsMain,
                Order = x.Order,
                ProductID = x.ProductID
            }).ToList();
        }
    }
}