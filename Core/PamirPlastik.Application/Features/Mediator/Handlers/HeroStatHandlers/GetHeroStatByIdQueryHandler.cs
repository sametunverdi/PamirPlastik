using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.HeroStatQueries;
using PamirPlastik.Application.Features.Mediator.Results.HeroStatResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroStatHandlers
{
    public class GetHeroStatByIdQueryHandler : IRequestHandler<GetHeroStatByIdQuery, GetHeroStatByIdQueryResult>
    {
        private readonly IRepository<HeroStat> _repository;
        public GetHeroStatByIdQueryHandler(IRepository<HeroStat> repository) { _repository = repository; }

        public async Task<GetHeroStatByIdQueryResult> Handle(GetHeroStatByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetHeroStatByIdQueryResult
            {
                HeroStatID = value.HeroStatID,
                Value = value.Value,
                Label_TR = value.Label_TR,
                Label_EN = value.Label_EN,
                IsActive = value.IsActive
            };
        }
    }
}