using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductFeatureResults;
using System.Collections.Generic;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductFeatureQueries
{
    public class GetProductFeatureByProductIdQuery : IRequest<List<GetProductFeatureQueryResult>>
    {
        public int ProductID { get; set; }

        public GetProductFeatureByProductIdQuery(int productId)
        {
            ProductID = productId;
        }
    }
}