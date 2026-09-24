using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.JobApplicationResults;
namespace PamirPlastik.Application.Features.Mediator.Queries.JobApplicationQueries
{
    public class GetJobApplicationByIdQuery : IRequest<GetJobApplicationByIdQueryResult>
    {
        public int Id { get; set; }
        public GetJobApplicationByIdQuery(int id) { Id = id; }
    }
}
