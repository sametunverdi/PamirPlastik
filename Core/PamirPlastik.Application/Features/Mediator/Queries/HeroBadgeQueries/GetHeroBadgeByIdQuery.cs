using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.HeroBadgeResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.HeroBadgeQueries
{
    public class GetHeroBadgeByIdQuery : IRequest<GetHeroBadgeByIdQueryResult>
    {
        public int Id { get; set; }

        public GetHeroBadgeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
