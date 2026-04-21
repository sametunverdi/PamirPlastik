using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductColorResults;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductColorQueries
{
    public class GetProductColorByProductIdQuery : IRequest<List<GetProductColorQueryResult>>
    {
        public int Id { get; set; } 

        public GetProductColorByProductIdQuery(int id)
        {
            Id = id;
        }
    }
}