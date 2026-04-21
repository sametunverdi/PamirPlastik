using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.TrendyolSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.TrendyolSettingHandlers
{
    public class RemoveTrendyolSettingCommandHandler : IRequestHandler<RemoveTrendyolSettingCommand>
    {
        private readonly IRepository<TrendyolSetting> _repository;

        public RemoveTrendyolSettingCommandHandler(IRepository<TrendyolSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTrendyolSettingCommand request, CancellationToken cancellationToken)
        {

            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null)
            {
                await _repository.RemoveAsync(value);
            }
        }
    }
}
