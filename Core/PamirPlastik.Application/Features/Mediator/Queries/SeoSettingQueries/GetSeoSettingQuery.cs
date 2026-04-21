using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.SeoSettingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.SeoSettingQueries
{
    public class GetSeoSettingQuery :IRequest<List<GetSeoSettingQueryResult>>
    {
    }
}
