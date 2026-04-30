using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductQueries
{
    public class GetProductPaginationQuery : IRequest<List<GetProductQueryResult>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int? CategoryID { get; set; } 

        public GetProductPaginationQuery(int page, int pageSize, int? categoryID = null)
        {
            Page = page;
            PageSize = pageSize;
            CategoryID = categoryID;
        }
    }
}
