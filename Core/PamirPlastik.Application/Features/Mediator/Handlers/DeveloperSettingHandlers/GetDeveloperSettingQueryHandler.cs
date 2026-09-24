using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.DeveloperSettingQueries;
using PamirPlastik.Application.Features.Mediator.Results.DeveloperSettingResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.DeveloperSettingHandlers
{
    public class GetDeveloperSettingQueryHandler : IRequestHandler<GetDeveloperSettingQuery, List<GetDeveloperSettingQueryResult>>
    {
        private readonly IRepository<DeveloperSetting> _repository;

        public GetDeveloperSettingQueryHandler(IRepository<DeveloperSetting> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetDeveloperSettingQueryResult>> Handle(GetDeveloperSettingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetDeveloperSettingQueryResult
            {
                DeveloperSettingID = x.DeveloperSettingID,
                DeveloperName = x.DeveloperName,
                DeveloperUrl = x.DeveloperUrl,
                SignatureText = x.SignatureText
            }).ToList();
        }
    }
}
