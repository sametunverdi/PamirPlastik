using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HomePageSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HomePageSettingHandlers
{
    public class CreateHomePageSettingCommandHandler : IRequestHandler<CreateHomePageSettingCommand>
    {
        private readonly IRepository<HomePageSetting> _repository;
        public CreateHomePageSettingCommandHandler(IRepository<HomePageSetting> repository) { _repository = repository; }
        public async Task Handle(CreateHomePageSettingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new HomePageSetting
            {
                HeroTitleTop_TR = request.HeroTitleTop_TR,
                HeroTitleTop_EN = request.HeroTitleTop_EN,
                HeroTitleMain_TR = request.HeroTitleMain_TR,
                HeroTitleMain_EN = request.HeroTitleMain_EN,
                HeroDescription_TR = request.HeroDescription_TR,
                HeroDescription_EN = request.HeroDescription_EN,
                HeroImageUrl = request.HeroImageUrl,
                ExperienceYear = request.ExperienceYear,
                ProductTypeCount = request.ProductTypeCount,
                ExportCountryCount = request.ExportCountryCount,
                ProdTitleTop_TR = request.ProdTitleTop_TR,
                ProdTitleTop_EN = request.ProdTitleTop_EN,
                ProdTitleMain_TR = request.ProdTitleMain_TR,
                ProdTitleMain_EN = request.ProdTitleMain_EN,
                ProdDescription_TR = request.ProdDescription_TR,
                ProdDescription_EN = request.ProdDescription_EN,
                ProdImageUrl = request.ProdImageUrl,
                ProdItem1Title_TR = request.ProdItem1Title_TR,
                ProdItem1Title_EN = request.ProdItem1Title_EN,
                ProdItem1Desc_TR = request.ProdItem1Desc_TR,
                ProdItem1Desc_EN = request.ProdItem1Desc_EN,
                ProdItem1Icon = request.ProdItem1Icon,
                ProdItem2Title_TR = request.ProdItem2Title_TR,
                ProdItem2Title_EN = request.ProdItem2Title_EN,
                ProdItem2Desc_TR = request.ProdItem2Desc_TR,
                ProdItem2Desc_EN = request.ProdItem2Desc_EN,
                ProdItem2Icon = request.ProdItem2Icon,
                ProdItem3Title_TR = request.ProdItem3Title_TR,
                ProdItem3Title_EN = request.ProdItem3Title_EN,
                ProdItem3Desc_TR = request.ProdItem3Desc_TR,
                ProdItem3Desc_EN = request.ProdItem3Desc_EN,
                ProdItem3Icon = request.ProdItem3Icon,
                EcomStoreScore = request.EcomStoreScore,
                EcomDeliveryMonthly = request.EcomDeliveryMonthly,
                EcomCommentCount = request.EcomCommentCount,
                EcomStoreLink = request.EcomStoreLink,
                GlobExportCountry = request.GlobExportCountry,
                GlobContinent = request.GlobContinent,
                GlobDealer = request.GlobDealer,
                GlobSectorYear = request.GlobSectorYear,
                CatTitleTop_TR = request.CatTitleTop_TR,
                CatTitleTop_EN = request.CatTitleTop_EN,
                CatTitleMain_TR = request.CatTitleMain_TR,
                CatTitleMain_EN = request.CatTitleMain_EN,
                CatDescription_TR = request.CatDescription_TR,
                CatDescription_EN = request.CatDescription_EN,
                FeatTitleTop_TR = request.FeatTitleTop_TR,
                FeatTitleTop_EN = request.FeatTitleTop_EN,
                FeatTitleMain_TR = request.FeatTitleMain_TR,
                FeatTitleMain_EN = request.FeatTitleMain_EN,
                FairTitleTop_TR = request.FairTitleTop_TR,
                FairTitleTop_EN = request.FairTitleTop_EN,
                FairTitleMain_TR = request.FairTitleMain_TR,
                FairTitleMain_EN = request.FairTitleMain_EN,
                FairDescription_TR = request.FairDescription_TR,
                FairDescription_EN = request.FairDescription_EN
            });
        }
    }
}
