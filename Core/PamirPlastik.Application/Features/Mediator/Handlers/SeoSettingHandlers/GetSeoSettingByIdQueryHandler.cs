using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.SeoSettingQueries;
using PamirPlastik.Application.Features.Mediator.Results.SeoSettingResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SeoSettingHandlers
{
    public class GetSeoSettingByIdQueryHandler : IRequestHandler<GetSeoSettingByIdQuery, GetSeoSettingByIdQueryResult>
    {
        private readonly IRepository<SeoSetting> _repository;

        public GetSeoSettingByIdQueryHandler(IRepository<SeoSetting> repository)
        {
            _repository = repository;
        }

        public async Task<GetSeoSettingByIdQueryResult> Handle(GetSeoSettingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetSeoSettingByIdQueryResult
            {
                SeoSettingID = value.SeoSettingID,
                PageName = value.PageName,
                MetaTitle_TR = value.MetaTitle_TR,
                MetaDescription_TR = value.MetaDescription_TR,
                MetaTitle_EN = value.MetaTitle_EN,
                MetaDescription_EN = value.MetaDescription_EN
            };
        }
    }
}