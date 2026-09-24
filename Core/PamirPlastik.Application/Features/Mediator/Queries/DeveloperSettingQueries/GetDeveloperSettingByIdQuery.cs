using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.DeveloperSettingResults;

namespace PamirPlastik.Application.Features.Mediator.Queries.DeveloperSettingQueries
{
    public class GetDeveloperSettingByIdQuery : IRequest<GetDeveloperSettingByIdQueryResult>
    {
        public int Id { get; set; }
        public GetDeveloperSettingByIdQuery(int id) { Id = id; }
    }
}
