using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ColorQueries;
using PamirPlastik.Application.Features.Mediator.Results.ColorResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ColorHandlers
{
    public class GetColorQueryHandler : IRequestHandler<GetColorQuery, List<GetColorQueryResult>>
    {
        private readonly IRepository<Color> _repository;

        public GetColorQueryHandler(IRepository<Color> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetColorQueryResult>> Handle(GetColorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetColorQueryResult
            {
                ColorID = x.ColorID,
                Name_TR = x.Name_TR,
                Name_EN = x.Name_EN,
                HexCode = x.HexCode
            }).ToList();
        }
    }
}