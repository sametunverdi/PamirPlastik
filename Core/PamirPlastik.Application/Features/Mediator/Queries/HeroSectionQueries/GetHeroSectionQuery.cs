using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.HeroSectionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.HeroSectionQueries
{
    public class GetHeroSectionQuery : IRequest<List<GetHeroSectionQueryResult>>
    {
    }
}
