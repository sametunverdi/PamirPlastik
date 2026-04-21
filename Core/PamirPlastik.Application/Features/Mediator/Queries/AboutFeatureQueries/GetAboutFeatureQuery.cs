using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.AboutFeatureResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.AboutFeatureQueries
{
    public class GetAboutFeatureQuery : IRequest<List<GetAboutFeatureQueryResult>>
    {
    }
}
