using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductImageResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductImageQueries
{
    public class GetProductImageByIdQuery : IRequest<GetProductImageByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductImageByIdQuery(int id)
        {
            Id = id;
        }
    }
}