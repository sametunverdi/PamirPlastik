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
    public class GetProductImagesByProductIdQueryHandler : IRequestHandler<GetProductImagesByProductIdQuery, List<GetProductImageQueryResult>>
    {
        private readonly IRepository<ProductImage> _repository;

        public GetProductImagesByProductIdQueryHandler(IRepository<ProductImage> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductImageQueryResult>> Handle(GetProductImagesByProductIdQuery request, CancellationToken cancellationToken)
        {
            // Note: Since IRepository doesn't natively have a GetByFilterAsync in the generic repository, we might have to fetch all and filter.
            // Ideally, there should be an IProductImageRepository, but since we're using generic IRepository, let's fetch all.
            var values = await _repository.GetAllAsync();
            return values.Where(x => x.ProductID == request.ProductId).Select(x => new GetProductImageQueryResult
            {
                ProductImageID = x.ProductImageID,
                ProductID = x.ProductID,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
