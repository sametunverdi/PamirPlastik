using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.SiteSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SiteSettingHandlers
{
    public class RemoveSiteSettingCommandHandler : IRequestHandler<RemoveSiteSettingCommand>
    {
        private readonly IRepository<SiteSetting> _repository;

        public RemoveSiteSettingCommandHandler(IRepository<SiteSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveSiteSettingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null)
            {
                await _repository.RemoveAsync(value);
            }
        }
    }
}