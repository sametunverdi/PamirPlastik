using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.SiteSettingQueries;
using PamirPlastik.Application.Features.Mediator.Results.SiteSettingResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SiteSettingHandlers
{
    public class GetSiteSettingQueryHandler : IRequestHandler<GetSiteSettingQuery, List<GetSiteSettingQueryResult>>
    {
        private readonly IRepository<SiteSetting> _repository;

        public GetSiteSettingQueryHandler(IRepository<SiteSetting> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSiteSettingQueryResult>> Handle(GetSiteSettingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetSiteSettingQueryResult
            {
                SiteSettingID = x.SiteSettingID,
                LogoPath = x.LogoPath,
                SiteName_TR = x.SiteName_TR,
                SiteName_EN = x.SiteName_EN,
                Phone = x.Phone,
                Email = x.Email,
                Address_TR = x.Address_TR,
                Address_EN = x.Address_EN,
                Instagram = x.Instagram,
                Facebook = x.Facebook,
                Linkedin = x.Linkedin,
                Youtube = x.Youtube
            }).ToList();
        }
    }
}