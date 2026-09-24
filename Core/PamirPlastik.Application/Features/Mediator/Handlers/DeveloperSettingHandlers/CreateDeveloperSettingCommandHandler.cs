using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.DeveloperSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.DeveloperSettingHandlers
{
    public class CreateDeveloperSettingCommandHandler : IRequestHandler<CreateDeveloperSettingCommand>
    {
        private readonly IRepository<DeveloperSetting> _repository;

        public CreateDeveloperSettingCommandHandler(IRepository<DeveloperSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateDeveloperSettingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new DeveloperSetting
            {
                DeveloperName = request.DeveloperName,
                DeveloperUrl = request.DeveloperUrl,
                SignatureText = request.SignatureText
            });
        }
    }
}
