using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.FairResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.FairQueries
{
    public class GetFairByIdQuery : IRequest<GetFairByIdQueryResult>
    {
        public GetFairByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
