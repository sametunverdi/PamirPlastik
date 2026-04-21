using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroStatCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroStatHandlers
{
    public class CreateHeroStatCommandHandler : IRequestHandler<CreateHeroStatCommand>
    {
        private readonly IRepository<HeroStat> _repository;
        public CreateHeroStatCommandHandler(IRepository<HeroStat> repository) { _repository = repository; }

        public async Task Handle(CreateHeroStatCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new HeroStat
            {
                Value = request.Value,
                Label_TR = request.Label_TR,
                Label_EN = request.Label_EN,
                IsActive = request.IsActive
            });
        }
    }
}