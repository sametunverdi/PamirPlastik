using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.AboutFeatureQueries;
using PamirPlastik.Application.Features.Mediator.Results.AboutFeatureResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutFeatureHandlers
{
    public class GetAboutFeatureQueryHandler : IRequestHandler<GetAboutFeatureQuery, List<GetAboutFeatureQueryResult>>
    {
        private readonly IRepository<AboutFeature> _repository;
        public GetAboutFeatureQueryHandler(IRepository<AboutFeature> repository) { _repository = repository; }

        public async Task<List<GetAboutFeatureQueryResult>> Handle(GetAboutFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutFeatureQueryResult
            {
                AboutFeatureID = x.AboutFeatureID,
                Order = x.Order,
                Title_TR = x.Title_TR,
                Title_EN = x.Title_EN,
                Description_TR = x.Description_TR,
                Description_EN = x.Description_EN,
                IsActive = x.IsActive,

                // ŞU SATIRI EKLE KANKA:
                AboutID = x.AboutID
            }).ToList();
        }
    }
}