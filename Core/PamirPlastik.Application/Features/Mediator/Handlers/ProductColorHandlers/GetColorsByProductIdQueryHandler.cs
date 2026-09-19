using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ProductColorQueries;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductColorHandlers
{
    public class GetColorsByProductIdQueryHandler : IRequestHandler<GetColorsByProductIdQuery, List<int>>
    {
        private readonly IRepository<ProductColor> _repository;

        public GetColorsByProductIdQueryHandler(IRepository<ProductColor> repository)
        {
            _repository = repository;
        }

        public async Task<List<int>> Handle(GetColorsByProductIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Where(x => x.ProductID == request.ProductID).Select(x => x.ColorID).ToList();
        }
    }
}