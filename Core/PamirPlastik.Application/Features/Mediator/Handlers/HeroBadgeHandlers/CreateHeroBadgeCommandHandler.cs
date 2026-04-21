using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroBadgeCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroBadgeHandlers
{
    public class CreateHeroBadgeCommandHandler : IRequestHandler<CreateHeroBadgeCommand>
    {
        private readonly IRepository<HeroBadge> _repository;
        public CreateHeroBadgeCommandHandler(IRepository<HeroBadge> repository) { _repository = repository; }

        public async Task Handle(CreateHeroBadgeCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new HeroBadge
            {
                Text_TR = request.Text_TR,
                Text_EN = request.Text_EN,
                IconName = request.IconName,
                IsActive = request.IsActive
            });
        }
    }
}