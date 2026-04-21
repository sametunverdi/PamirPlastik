using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductFeatureQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductFeatureResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductFeatureHandlers
{
    public class GetProductFeatureByProductIdQueryHandler : IRequestHandler<GetProductFeatureByProductIdQuery, List<GetProductFeatureQueryResult>>
    {
        private readonly IRepository<ProductFeature> _repository;

        public GetProductFeatureByProductIdQueryHandler(IRepository<ProductFeature> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductFeatureQueryResult>> Handle(GetProductFeatureByProductIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Where(x => x.ProductID == request.ProductID).Select(x => new GetProductFeatureQueryResult
            {
                ProductFeatureID = x.ProductFeatureID,
                Feature_TR = x.Feature_TR,
                Feature_EN = x.Feature_EN,
                ProductID = x.ProductID
            }).ToList();
        }
    }
}