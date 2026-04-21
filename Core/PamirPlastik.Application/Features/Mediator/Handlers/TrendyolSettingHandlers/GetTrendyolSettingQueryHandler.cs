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
    public class GetTrendyolSettingQueryHandler : IRequestHandler<GetTrendyolSettingQuery, List<GetTrendyolSettingQueryResult>>
    {
        private readonly IRepository<TrendyolSetting> _repository;

        public GetTrendyolSettingQueryHandler(IRepository<TrendyolSetting> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTrendyolSettingQueryResult>> Handle(GetTrendyolSettingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTrendyolSettingQueryResult
            {
                TrendyolSettingID = x.TrendyolSettingID,
                StoreUrl = x.StoreUrl,
                Rating = x.Rating,
                MonthlyDelivery = x.MonthlyDelivery,
                ReviewCount = x.ReviewCount
            }).ToList();
        }
    }
}
