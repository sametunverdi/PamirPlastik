using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ColorResults;

namespace PamirPlastik.Application.Features.Mediator.Queries.ColorQueries
{
    public class GetColorByIdQuery : IRequest<GetColorByIdQueryResult>
    {
        public int Id { get; set; }
        public GetColorByIdQuery(int id)
        {
            Id = id;
        }
    }
}