using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.HomePageSettingResults;
namespace PamirPlastik.Application.Features.Mediator.Queries.HomePageSettingQueries
{
    public class GetHomePageSettingByIdQuery : IRequest<GetHomePageSettingByIdQueryResult>
    {
        public int Id { get; set; }
        public GetHomePageSettingByIdQuery(int id) { Id = id; }
    }
}
