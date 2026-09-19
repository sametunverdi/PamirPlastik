using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.HomePageSettingQueries;
using PamirPlastik.Application.Features.Mediator.Results.HomePageSettingResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HomePageSettingHandlers
{
    public class GetHomePageSettingByIdQueryHandler : IRequestHandler<GetHomePageSettingByIdQuery, GetHomePageSettingByIdQueryResult>
    {
        private readonly IRepository<HomePageSetting> _repository;

        public GetHomePageSettingByIdQueryHandler(IRepository<HomePageSetting> repository)
        {
            _repository = repository;
        }

        public async Task<GetHomePageSettingByIdQueryResult> Handle(GetHomePageSettingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetHomePageSettingByIdQueryResult
            {
                HomePageSettingID = value.HomePageSettingID,
                HeroTitleTop_TR = value.HeroTitleTop_TR,
                HeroTitleTop_EN = value.HeroTitleTop_EN,
                HeroTitleMain_TR = value.HeroTitleMain_TR,
                HeroTitleMain_EN = value.HeroTitleMain_EN,
                HeroDescription_TR = value.HeroDescription_TR,
                HeroDescription_EN = value.HeroDescription_EN,
                HeroImageUrl = value.HeroImageUrl,
                ExperienceYear = value.ExperienceYear,
                ProductTypeCount = value.ProductTypeCount,
                ExportCountryCount = value.ExportCountryCount,
                ProdTitleTop_TR = value.ProdTitleTop_TR,
                ProdTitleTop_EN = value.ProdTitleTop_EN,
                ProdTitleMain_TR = value.ProdTitleMain_TR,
                ProdTitleMain_EN = value.ProdTitleMain_EN,
                ProdDescription_TR = value.ProdDescription_TR,
                ProdDescription_EN = value.ProdDescription_EN,
                ProdImageUrl = value.ProdImageUrl,
                ProdItem1Title_TR = value.ProdItem1Title_TR,
                ProdItem1Title_EN = value.ProdItem1Title_EN,
                ProdItem1Desc_TR = value.ProdItem1Desc_TR,
                ProdItem1Desc_EN = value.ProdItem1Desc_EN,
                ProdItem1Icon = value.ProdItem1Icon,
                ProdItem2Title_TR = value.ProdItem2Title_TR,
                ProdItem2Title_EN = value.ProdItem2Title_EN,
                ProdItem2Desc_TR = value.ProdItem2Desc_TR,
                ProdItem2Desc_EN = value.ProdItem2Desc_EN,
                ProdItem2Icon = value.ProdItem2Icon,
                ProdItem3Title_TR = value.ProdItem3Title_TR,
                ProdItem3Title_EN = value.ProdItem3Title_EN,
                ProdItem3Desc_TR = value.ProdItem3Desc_TR,
                ProdItem3Desc_EN = value.ProdItem3Desc_EN,
                ProdItem3Icon = value.ProdItem3Icon,
                EcomStoreScore = value.EcomStoreScore,
                EcomDeliveryMonthly = value.EcomDeliveryMonthly,
                EcomCommentCount = value.EcomCommentCount,
                EcomStoreLink = value.EcomStoreLink,
                GlobExportCountry = value.GlobExportCountry,
                GlobContinent = value.GlobContinent,
                GlobDealer = value.GlobDealer,
                GlobSectorYear = value.GlobSectorYear,
                CatTitleTop_TR = value.CatTitleTop_TR,
                CatTitleTop_EN = value.CatTitleTop_EN,
                CatTitleMain_TR = value.CatTitleMain_TR,
                CatTitleMain_EN = value.CatTitleMain_EN,
                CatDescription_TR = value.CatDescription_TR,
                CatDescription_EN = value.CatDescription_EN,
                FeatTitleTop_TR = value.FeatTitleTop_TR,
                FeatTitleTop_EN = value.FeatTitleTop_EN,
                FeatTitleMain_TR = value.FeatTitleMain_TR,
                FeatTitleMain_EN = value.FeatTitleMain_EN,
                FairTitleTop_TR = value.FairTitleTop_TR,
                FairTitleTop_EN = value.FairTitleTop_EN,
                FairTitleMain_TR = value.FairTitleMain_TR,
                FairTitleMain_EN = value.FairTitleMain_EN,
                FairDescription_TR = value.FairDescription_TR,
                FairDescription_EN = value.FairDescription_EN
            };
        }
    }
}
