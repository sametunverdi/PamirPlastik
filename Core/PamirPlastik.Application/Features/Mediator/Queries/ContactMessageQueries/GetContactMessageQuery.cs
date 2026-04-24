using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.ContactMessageResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.ContactMessageQueries
{
    public class GetContactMessageQuery : IRequest<List<GetContactMessageQueryResult>>
    {
    }
}
