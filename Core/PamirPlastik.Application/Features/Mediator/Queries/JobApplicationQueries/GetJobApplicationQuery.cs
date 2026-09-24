using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.JobApplicationResults;
using System.Collections.Generic;
namespace PamirPlastik.Application.Features.Mediator.Queries.JobApplicationQueries
{
    public class GetJobApplicationQuery : IRequest<List<GetJobApplicationQueryResult>> {}
}
