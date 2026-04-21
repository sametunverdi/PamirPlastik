using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ManufacturingFeatureQueries;
using PamirPlastik.Application.Features.Mediator.Results.ManufacturingFeatureResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingFeatureHandlers
{
    public class GetManufacturingFeatureByIdQueryHandler : IRequestHandler<GetManufacturingFeatureByIdQuery, GetManufacturingFeatureByIdQueryResult>
    {
        private readonly IRepository<ManufacturingFeature> _repository;
        public GetManufacturingFeatureByIdQueryHandler(IRepository<ManufacturingFeature> repository) { _repository = repository; }

        public async Task<GetManufacturingFeatureByIdQueryResult> Handle(GetManufacturingFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetManufacturingFeatureByIdQueryResult
            {
                ManufacturingFeatureID = value.ManufacturingFeatureID,
                Title_TR = value.Title_TR,
                Description_TR = value.Description_TR,
                Title_EN = value.Title_EN,
                Description_EN = value.Description_EN,
                IconName = value.IconName,
                IsActive = value.IsActive
            };
        }
    }
}