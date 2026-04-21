using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.TrendyolSettingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.TrendyolSettingQueries
{
    public  class GetTrendyolSettingByIdQuery:IRequest<GetTrendyolSettingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTrendyolSettingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
