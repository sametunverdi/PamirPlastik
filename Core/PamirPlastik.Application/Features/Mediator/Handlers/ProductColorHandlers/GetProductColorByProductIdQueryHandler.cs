using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductColorQueries;
using PamirPlastik.Application.Features.Mediator.Results.ProductColorResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductColorHandlers
{
    public class GetProductColorByProductIdQueryHandler : IRequestHandler<GetProductColorByProductIdQuery, List<GetProductColorQueryResult>>
    {
        private readonly IRepository<ProductColor> _repository;

        public GetProductColorByProductIdQueryHandler(IRepository<ProductColor> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductColorQueryResult>> Handle(GetProductColorByProductIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            // Burada request.Id artık bizim ProductID'miz oldu
            return values.Where(x => x.ProductID == request.Id).Select(x => new GetProductColorQueryResult
            {
                ProductColorID = x.ProductColorID,
                ColorName_TR = x.ColorName_TR,
                ColorName_EN = x.ColorName_EN,
                ColorHex = x.ColorHex,
                ProductID = x.ProductID
            }).ToList();
        }
    }
}