using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroSectionCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroSectionHandlers
{
    public class RemoveHeroSectionCommandHandler : IRequestHandler<RemoveHeroSectionCommand>
    {
        private readonly IRepository<HeroSection> _repository;
        public RemoveHeroSectionCommandHandler(IRepository<HeroSection> repository) { _repository = repository; }

        public async Task Handle(RemoveHeroSectionCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null) { await _repository.RemoveAsync(value); }
        }
    }
}