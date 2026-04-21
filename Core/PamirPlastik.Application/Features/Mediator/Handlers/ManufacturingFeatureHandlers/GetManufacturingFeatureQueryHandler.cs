using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ManufacturingFeatureQueries;
using PamirPlastik.Application.Features.Mediator.Results.ManufacturingFeatureResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingFeatureHandlers
{
    public class GetManufacturingFeatureQueryHandler : IRequestHandler<GetManufacturingFeatureQuery, List<GetManufacturingFeatureQueryResult>>
    {
        private readonly IRepository<ManufacturingFeature> _repository;
        public GetManufacturingFeatureQueryHandler(IRepository<ManufacturingFeature> repository) { _repository = repository; }

        public async Task<List<GetManufacturingFeatureQueryResult>> Handle(GetManufacturingFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetManufacturingFeatureQueryResult
            {
                ManufacturingFeatureID = x.ManufacturingFeatureID,
                Title_TR = x.Title_TR,
                Description_TR = x.Description_TR,
                Title_EN = x.Title_EN,
                Description_EN = x.Description_EN,
                IconName = x.IconName,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}