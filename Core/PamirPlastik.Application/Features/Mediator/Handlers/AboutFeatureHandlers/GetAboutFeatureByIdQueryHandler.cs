using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.AboutFeatureQueries;
using PamirPlastik.Application.Features.Mediator.Results.AboutFeatureResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutFeatureHandlers
{
    public class GetAboutFeatureByIdQueryHandler : IRequestHandler<GetAboutFeatureByIdQuery, GetAboutFeatureByIdQueryResult>
    {
        private readonly IRepository<AboutFeature> _repository;
        public GetAboutFeatureByIdQueryHandler(IRepository<AboutFeature> repository) { _repository = repository; }

        public async Task<GetAboutFeatureByIdQueryResult> Handle(GetAboutFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetAboutFeatureByIdQueryResult
            {
                AboutFeatureID = value.AboutFeatureID,
                Order = value.Order,
                Title_TR = value.Title_TR,
                Title_EN = value.Title_EN,
                Description_TR = value.Description_TR,
                Description_EN = value.Description_EN,
                IsActive = value.IsActive,

                // ŞU SATIRI EKLE KANKA:
                AboutID = value.AboutID
            };
        }
    }
}