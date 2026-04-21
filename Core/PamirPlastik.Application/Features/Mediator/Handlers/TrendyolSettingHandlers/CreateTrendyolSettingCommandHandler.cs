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
    public class CreateTrendyolSettingCommandHandler : IRequestHandler<CreateTrendyolSettingCommand>
    {
        private readonly IRepository<TrendyolSetting> _repository;

        public CreateTrendyolSettingCommandHandler(IRepository<TrendyolSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTrendyolSettingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TrendyolSetting
            {
                StoreUrl = request.StoreUrl,
                Rating = request.Rating,
                MonthlyDelivery = request.MonthlyDelivery,
                ReviewCount = request.ReviewCount
            });
        }
    }
}
