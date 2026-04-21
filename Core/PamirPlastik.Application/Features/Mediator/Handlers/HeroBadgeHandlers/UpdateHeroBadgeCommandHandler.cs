using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroBadgeCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroBadgeHandlers
{
    public class UpdateHeroBadgeCommandHandler : IRequestHandler<UpdateHeroBadgeCommand>
    {
        private readonly IRepository<HeroBadge> _repository;
        public UpdateHeroBadgeCommandHandler(IRepository<HeroBadge> repository) { _repository = repository; }

        public async Task Handle(UpdateHeroBadgeCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.HeroBadgeID);
            if (values != null)
            {
                values.Text_TR = request.Text_TR;
                values.Text_EN = request.Text_EN;
                values.IconName = request.IconName;
                values.IsActive = request.IsActive;
                await _repository.UpdateAsync(values);
            }
        }
    }
}