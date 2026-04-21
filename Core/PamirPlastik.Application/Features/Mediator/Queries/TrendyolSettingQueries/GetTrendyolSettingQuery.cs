using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.TrendyolSettingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.TrendyolSettingQueries
{
    public class GetTrendyolSettingQuery:IRequest<List<GetTrendyolSettingQueryResult>>
    {

    }
}
