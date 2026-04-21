using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.SeoSettingQueries;
using PamirPlastik.Application.Features.Mediator.Results.SeoSettingResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SeoSettingHandlers
{
    public class GetSeoSettingQueryHandler : IRequestHandler<GetSeoSettingQuery, List<GetSeoSettingQueryResult>>
    {
        private readonly IRepository<SeoSetting> _repository;

        public GetSeoSettingQueryHandler(IRepository<SeoSetting> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSeoSettingQueryResult>> Handle(GetSeoSettingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSeoSettingQueryResult
            {
                SeoSettingID = x.SeoSettingID,
                PageName = x.PageName,
                MetaTitle_TR = x.MetaTitle_TR,
                MetaDescription_TR = x.MetaDescription_TR,
                MetaTitle_EN = x.MetaTitle_EN,
                MetaDescription_EN = x.MetaDescription_EN
            }).ToList();
        }
    }
}