using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.HeroBadgeQueries;
using PamirPlastik.Application.Features.Mediator.Results.HeroBadgeResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroBadgeHandlers
{
    public class GetHeroBadgeQueryHandler : IRequestHandler<GetHeroBadgeQuery, List<GetHeroBadgeQueryResult>>
    {
        private readonly IRepository<HeroBadge> _repository;
        public GetHeroBadgeQueryHandler(IRepository<HeroBadge> repository) { _repository = repository; }

        public async Task<List<GetHeroBadgeQueryResult>> Handle(GetHeroBadgeQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetHeroBadgeQueryResult
            {
                HeroBadgeID = x.HeroBadgeID,
                Text_TR = x.Text_TR,
                Text_EN = x.Text_EN,
                IconName = x.IconName,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}