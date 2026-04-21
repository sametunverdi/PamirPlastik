using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.HeroStatResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.HeroStatQueries
{
    public class GetHeroStatQuery : IRequest<List<GetHeroStatQueryResult>>
    {
    }
}
