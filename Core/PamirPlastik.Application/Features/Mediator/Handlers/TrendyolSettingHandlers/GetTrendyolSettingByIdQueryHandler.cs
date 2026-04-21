using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.TrendyolSettingQueries;
using PamirPlastik.Application.Features.Mediator.Results.TrendyolSettingResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.TrendyolSettingHandlers
{
    public class GetTrendyolSettingByIdQueryHandler : IRequestHandler<GetTrendyolSettingByIdQuery, GetTrendyolSettingByIdQueryResult>
    {
        private readonly IRepository<TrendyolSetting> _repository;

        public GetTrendyolSettingByIdQueryHandler(IRepository<TrendyolSetting> repository)
        {
            _repository = repository;
        }

        public async Task<GetTrendyolSettingByIdQueryResult> Handle(GetTrendyolSettingByIdQuery request, CancellationToken cancellationToken)
        {        
            var values = await _repository.GetByIdAsync(request.Id);

            if (values == null) return null; 
            return new GetTrendyolSettingByIdQueryResult
            {
                TrendyolSettingID = values.TrendyolSettingID,
                StoreUrl = values.StoreUrl,
                Rating = values.Rating,
                MonthlyDelivery = values.MonthlyDelivery,
                ReviewCount = values.ReviewCount
            };
        }
    }
}
