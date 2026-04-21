using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroBadgeCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroBadgeHandlers
{
    public class RemoveHeroBadgeCommandHandler : IRequestHandler<RemoveHeroBadgeCommand>
    {
        private readonly IRepository<HeroBadge> _repository;
        public RemoveHeroBadgeCommandHandler(IRepository<HeroBadge> repository) { _repository = repository; }

        public async Task Handle(RemoveHeroBadgeCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null) { await _repository.RemoveAsync(value); }
        }
    }
}