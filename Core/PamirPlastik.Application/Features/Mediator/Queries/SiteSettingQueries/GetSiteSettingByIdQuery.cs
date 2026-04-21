using MediatR;
using PamirPlastik.Application.Features.Mediator.Results.SiteSettingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Queries.SiteSettingQueries
{
    public class GetSiteSettingByIdQuery : IRequest<GetSiteSettingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetSiteSettingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
