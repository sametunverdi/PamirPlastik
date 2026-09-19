using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ColorQueries;
using PamirPlastik.Application.Features.Mediator.Results.ColorResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ColorHandlers
{
    public class GetColorByIdQueryHandler : IRequestHandler<GetColorByIdQuery, GetColorByIdQueryResult>
    {
        private readonly IRepository<Color> _repository;

        public GetColorByIdQueryHandler(IRepository<Color> repository)
        {
            _repository = repository;
        }

        public async Task<GetColorByIdQueryResult> Handle(GetColorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetColorByIdQueryResult
            {
                ColorID = values.ColorID,
                Name_TR = values.Name_TR,
                Name_EN = values.Name_EN,
                HexCode = values.HexCode
            };
        }
    }
}