using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.HeroStatQueries;
using PamirPlastik.Application.Features.Mediator.Results.HeroStatResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroStatHandlers
{
    public class GetHeroStatQueryHandler : IRequestHandler<GetHeroStatQuery, List<GetHeroStatQueryResult>>
    {
        private readonly IRepository<HeroStat> _repository;
        public GetHeroStatQueryHandler(IRepository<HeroStat> repository) { _repository = repository; }

        public async Task<List<GetHeroStatQueryResult>> Handle(GetHeroStatQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetHeroStatQueryResult
            {
                HeroStatID = x.HeroStatID,
                Value = x.Value,
                Label_TR = x.Label_TR,
                Label_EN = x.Label_EN,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}