using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.SiteSettingQueries;
using PamirPlastik.Application.Features.Mediator.Results.SiteSettingResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SiteSettingHandlers
{
    public class GetSiteSettingByIdQueryHandler : IRequestHandler<GetSiteSettingByIdQuery, GetSiteSettingByIdQueryResult>
    {
        private readonly IRepository<SiteSetting> _repository;

        public GetSiteSettingByIdQueryHandler(IRepository<SiteSetting> repository)
        {
            _repository = repository;
        }

        public async Task<GetSiteSettingByIdQueryResult> Handle(GetSiteSettingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            if (values == null) return null;
            return new GetSiteSettingByIdQueryResult
            {
                SiteSettingID = values.SiteSettingID,
                LogoPath = values.LogoPath,
                SiteName_TR = values.SiteName_TR,
                SiteName_EN = values.SiteName_EN,
                Phone = values.Phone,
                Email = values.Email,
                Address_TR = values.Address_TR,
                Address_EN = values.Address_EN,
                Instagram = values.Instagram,
                Facebook = values.Facebook,
                Linkedin = values.Linkedin,
                Youtube = values.Youtube
            };
        }
    }
}
