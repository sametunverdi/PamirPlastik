using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ManufacturingSectionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.ManufacturingSectionQueries
{
    public class GetManufacturingSectionByIdQuery : IRequest<GetManufacturingSectionByIdQueryResult>
    {
        public int Id { get; set; }

        public GetManufacturingSectionByIdQuery(int id)
        {
            Id = id;
        }
    }
}
