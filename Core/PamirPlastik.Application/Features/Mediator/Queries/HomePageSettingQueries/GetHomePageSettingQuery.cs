using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.HomePageSettingResults;
using System.Collections.Generic;
namespace PamirPlastik.Application.Features.Mediator.Queries.HomePageSettingQueries
{
    public class GetHomePageSettingQuery : IRequest<List<GetHomePageSettingQueryResult>> { }
}
