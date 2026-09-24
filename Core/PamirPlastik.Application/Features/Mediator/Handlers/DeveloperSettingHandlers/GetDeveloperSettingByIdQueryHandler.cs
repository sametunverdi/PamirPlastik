using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.DeveloperSettingQueries;
using PamirPlastik.Application.Features.Mediator.Results.DeveloperSettingResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.DeveloperSettingHandlers
{
    public class GetDeveloperSettingByIdQueryHandler : IRequestHandler<GetDeveloperSettingByIdQuery, GetDeveloperSettingByIdQueryResult>
    {
        private readonly IRepository<DeveloperSetting> _repository;

        public GetDeveloperSettingByIdQueryHandler(IRepository<DeveloperSetting> repository)
        {
            _repository = repository;
        }

        public async Task<GetDeveloperSettingByIdQueryResult> Handle(GetDeveloperSettingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetDeveloperSettingByIdQueryResult
            {
                DeveloperSettingID = values.DeveloperSettingID,
                DeveloperName = values.DeveloperName,
                DeveloperUrl = values.DeveloperUrl,
                SignatureText = values.SignatureText
            };
        }
    }
}
