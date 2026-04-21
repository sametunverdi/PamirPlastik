using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.HeroBadgeResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.HeroBadgeQueries
{
    public class GetHeroBadgeQuery : IRequest<List<GetHeroBadgeQueryResult>>
    {
    }
}
