using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.SeoSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SeoSettingHandlers
{
    public class RemoveSeoSettingCommandHandler : IRequestHandler<RemoveSeoSettingCommand>
    {
        private readonly IRepository<SeoSetting> _repository;

        public RemoveSeoSettingCommandHandler(IRepository<SeoSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveSeoSettingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null)
            {
                await _repository.RemoveAsync(value);
            }
        }
    }
}