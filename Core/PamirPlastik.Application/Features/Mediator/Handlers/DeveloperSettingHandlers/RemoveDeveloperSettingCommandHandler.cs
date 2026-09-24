using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.DeveloperSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.DeveloperSettingHandlers
{
    public class RemoveDeveloperSettingCommandHandler : IRequestHandler<RemoveDeveloperSettingCommand>
    {
        private readonly IRepository<DeveloperSetting> _repository;

        public RemoveDeveloperSettingCommandHandler(IRepository<DeveloperSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveDeveloperSettingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(values);
        }
    }
}
