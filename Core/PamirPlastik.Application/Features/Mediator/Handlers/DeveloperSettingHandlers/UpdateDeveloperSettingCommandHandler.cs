using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.DeveloperSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.DeveloperSettingHandlers
{
    public class UpdateDeveloperSettingCommandHandler : IRequestHandler<UpdateDeveloperSettingCommand>
    {
        private readonly IRepository<DeveloperSetting> _repository;

        public UpdateDeveloperSettingCommandHandler(IRepository<DeveloperSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateDeveloperSettingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.DeveloperSettingID);
            values.DeveloperName = request.DeveloperName;
            values.DeveloperUrl = request.DeveloperUrl;
            values.SignatureText = request.SignatureText;
            await _repository.UpdateAsync(values);
        }
    }
}
