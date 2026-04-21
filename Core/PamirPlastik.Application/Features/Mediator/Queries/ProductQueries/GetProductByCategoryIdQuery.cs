using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductQueries
{
    public class GetProductByCategoryIdQuery : IRequest<List<GetProductQueryResult>>
    {
        public int CategoryId { get; set; }

        public GetProductByCategoryIdQuery(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
