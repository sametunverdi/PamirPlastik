using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductImageResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductImageQueries
{
    public class GetProductImageByProductIdQuery : IRequest<List<GetProductImageQueryResult>>
    {
        public int ProductID { get; set; }
        public GetProductImageByProductIdQuery(int productId) { ProductID = productId; }
    }
}
