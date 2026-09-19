using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ProductResults;

namespace PamirPlastik.Application.Features.Mediator.Queries.ProductQueries
{
    public class GetProductBySlugQuery : IRequest<GetProductBySlugQueryResult>
    {
        public string Slug { get; set; }
        public GetProductBySlugQuery(string slug)
        {
            Slug = slug;
        }
    }
}
