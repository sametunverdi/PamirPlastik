using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductQueries
{
    public class GetFeaturedProductQuery : IRequest<List<GetProductQueryResult>>
    {
    }
}
