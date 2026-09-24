using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.DeveloperSettingResults;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Queries.DeveloperSettingQueries
{
    public class GetDeveloperSettingQuery : IRequest<List<GetDeveloperSettingQueryResult>>
    {
    }
}
