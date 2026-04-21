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
    public class UpdateTrendyolSettingCommandHandler : IRequestHandler<UpdateTrendyolSettingCommand>
    {
        private readonly IRepository<TrendyolSetting> _repository;

        public UpdateTrendyolSettingCommandHandler(IRepository<TrendyolSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTrendyolSettingCommand request, CancellationToken cancellationToken)
        {
           
            var values = await _repository.GetByIdAsync(request.TrendyolSettingID);

            if (values != null)
            {      
                values.StoreUrl = request.StoreUrl;
                values.Rating = request.Rating;
                values.MonthlyDelivery = request.MonthlyDelivery;
                values.ReviewCount = request.ReviewCount;
       
                await _repository.UpdateAsync(values);
            }
        }
    }
}
