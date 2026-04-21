using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.HeroBadgeQueries;
using PamirPlastik.Application.Features.Mediator.Results.HeroBadgeResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroBadgeHandlers
{
    public class GetHeroBadgeByIdQueryHandler : IRequestHandler<GetHeroBadgeByIdQuery, GetHeroBadgeByIdQueryResult>
    {
        private readonly IRepository<HeroBadge> _repository;
        public GetHeroBadgeByIdQueryHandler(IRepository<HeroBadge> repository) { _repository = repository; }

        public async Task<GetHeroBadgeByIdQueryResult> Handle(GetHeroBadgeByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetHeroBadgeByIdQueryResult
            {
                HeroBadgeID = value.HeroBadgeID,
                Text_TR = value.Text_TR,
                Text_EN = value.Text_EN,
                IconName = value.IconName,
                IsActive = value.IsActive
            };
        }
    }
}