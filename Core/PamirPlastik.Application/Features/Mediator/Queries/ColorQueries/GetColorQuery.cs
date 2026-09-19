using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ColorResults;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Queries.ColorQueries
{
    public class GetColorQuery : IRequest<List<GetColorQueryResult>>
    {
    }
}