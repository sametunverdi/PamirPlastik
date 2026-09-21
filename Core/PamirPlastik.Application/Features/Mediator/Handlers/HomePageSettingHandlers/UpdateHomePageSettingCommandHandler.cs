using MediatR;

using PamirPlastik.Application.Features.Mediator.Commands.HomePageSettingCommands;

using PamirPlastik.Application.Interfaces;

using PamirPlastik.Domain.Entities;

using System.Threading;

using System.Threading.Tasks;



namespace PamirPlastik.Application.Features.Mediator.Handlers.HomePageSettingHandlers

{

    public class UpdateHomePageSettingCommandHandler : IRequestHandler<UpdateHomePageSettingCommand>

    {

        private readonly IRepository<HomePageSetting> _repository;

        public UpdateHomePageSettingCommandHandler(IRepository<HomePageSetting> repository) { _repository = repository; }

        public async Task Handle(UpdateHomePageSettingCommand request, CancellationToken cancellationToken)

        {

            var value = await _repository.GetByIdAsync(request.HomePageSettingID);

            value.HeroTitleTop_TR = request.HeroTitleTop_TR;

            value.HeroTitleTop_EN = request.HeroTitleTop_EN;

            value.HeroTitleMain_TR = request.HeroTitleMain_TR;

            value.HeroTitleMain_EN = request.HeroTitleMain_EN;

            value.HeroDescription_TR = request.HeroDescription_TR;

            value.HeroDescription_EN = request.HeroDescription_EN;

            value.HeroImageUrl = request.HeroImageUrl;
            value.HeroBadge1_TR = request.HeroBadge1_TR;
            value.HeroBadge1_EN = request.HeroBadge1_EN;
            value.HeroBadge2_TR = request.HeroBadge2_TR;
            value.HeroBadge2_EN = request.HeroBadge2_EN;
            value.HeroBadge3_TR = request.HeroBadge3_TR;
            value.HeroBadge3_EN = request.HeroBadge3_EN;

            value.ExperienceYear = request.ExperienceYear;

            value.ProductTypeCount = request.ProductTypeCount;

            value.ExportCountryCount = request.ExportCountryCount;

            value.ProdTitleTop_TR = request.ProdTitleTop_TR;

            value.ProdTitleTop_EN = request.ProdTitleTop_EN;

            value.ProdTitleMain_TR = request.ProdTitleMain_TR;

            value.ProdTitleMain_EN = request.ProdTitleMain_EN;

            value.ProdDescription_TR = request.ProdDescription_TR;

            value.ProdDescription_EN = request.ProdDescription_EN;

            value.ProdImageUrl = request.ProdImageUrl;

            value.ProdItem1Title_TR = request.ProdItem1Title_TR;

            value.ProdItem1Title_EN = request.ProdItem1Title_EN;

            value.ProdItem1Desc_TR = request.ProdItem1Desc_TR;

            value.ProdItem1Desc_EN = request.ProdItem1Desc_EN;

            value.ProdItem1Icon = request.ProdItem1Icon;

            value.ProdItem2Title_TR = request.ProdItem2Title_TR;

            value.ProdItem2Title_EN = request.ProdItem2Title_EN;

            value.ProdItem2Desc_TR = request.ProdItem2Desc_TR;

            value.ProdItem2Desc_EN = request.ProdItem2Desc_EN;

            value.ProdItem2Icon = request.ProdItem2Icon;

            value.ProdItem3Title_TR = request.ProdItem3Title_TR;

            value.ProdItem3Title_EN = request.ProdItem3Title_EN;

            value.ProdItem3Desc_TR = request.ProdItem3Desc_TR;

            value.ProdItem3Desc_EN = request.ProdItem3Desc_EN;

            value.ProdItem3Icon = request.ProdItem3Icon;

            value.EcomStoreScore = request.EcomStoreScore;

            value.EcomDeliveryMonthly = request.EcomDeliveryMonthly;

            value.EcomCommentCount = request.EcomCommentCount;

            value.EcomStoreLink = request.EcomStoreLink;

            value.GlobExportCountry = request.GlobExportCountry;

            value.GlobContinent = request.GlobContinent;

            value.GlobDealer = request.GlobDealer;

            value.GlobSectorYear = request.GlobSectorYear;

            value.CatTitleTop_TR = request.CatTitleTop_TR;

            value.CatTitleTop_EN = request.CatTitleTop_EN;

            value.CatTitleMain_TR = request.CatTitleMain_TR;

            value.CatTitleMain_EN = request.CatTitleMain_EN;

            value.CatDescription_TR = request.CatDescription_TR;

            value.CatDescription_EN = request.CatDescription_EN;

            value.FeatTitleTop_TR = request.FeatTitleTop_TR;

            value.FeatTitleTop_EN = request.FeatTitleTop_EN;

            value.FeatTitleMain_TR = request.FeatTitleMain_TR;

            value.FeatTitleMain_EN = request.FeatTitleMain_EN;

            value.FairTitleTop_TR = request.FairTitleTop_TR;

            value.FairTitleTop_EN = request.FairTitleTop_EN;

            value.FairTitleMain_TR = request.FairTitleMain_TR;

            value.FairTitleMain_EN = request.FairTitleMain_EN;

            value.FairDescription_TR = request.FairDescription_TR;

            value.FairDescription_EN = request.FairDescription_EN;

            

            await _repository.UpdateAsync(value);

        }

    }

}

