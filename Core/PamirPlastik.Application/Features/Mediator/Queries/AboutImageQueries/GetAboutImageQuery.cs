using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.AboutImageResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.AboutImageQueries
{
    public class GetAboutImageQuery : IRequest<List<GetAboutImageQueryResult>>
    {
    }
}
