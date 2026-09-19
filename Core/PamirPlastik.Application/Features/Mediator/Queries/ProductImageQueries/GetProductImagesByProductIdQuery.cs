using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductImageResults;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductImageQueries
{
    public class GetProductImagesByProductIdQuery : IRequest<List<GetProductImageQueryResult>>
    {
        public int ProductId { get; set; }

        public GetProductImagesByProductIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
