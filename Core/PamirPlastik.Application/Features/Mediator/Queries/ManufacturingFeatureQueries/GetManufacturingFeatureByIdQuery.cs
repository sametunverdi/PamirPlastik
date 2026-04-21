using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ManufacturingFeatureResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.ManufacturingFeatureQueries
{
    public class GetManufacturingFeatureByIdQuery : IRequest<GetManufacturingFeatureByIdQueryResult>
    {
        public int Id { get; set; }

        public GetManufacturingFeatureByIdQuery(int id)
        {
            Id = id;
        }
    }
}
