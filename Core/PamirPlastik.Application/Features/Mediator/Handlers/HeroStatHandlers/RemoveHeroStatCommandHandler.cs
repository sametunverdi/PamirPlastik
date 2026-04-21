using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroStatCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroStatHandlers
{
    public class RemoveHeroStatCommandHandler : IRequestHandler<RemoveHeroStatCommand>
    {
        private readonly IRepository<HeroStat> _repository;
        public RemoveHeroStatCommandHandler(IRepository<HeroStat> repository) { _repository = repository; }

        public async Task Handle(RemoveHeroStatCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null) { await _repository.RemoveAsync(value); }
        }
    }
}