using MediatR;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductColorQueries
{
    public class GetColorsByProductIdQuery : IRequest<List<int>>
    {
        public int ProductID { get; set; }
        public GetColorsByProductIdQuery(int productId)
        {
            ProductID = productId;
        }
    }
}