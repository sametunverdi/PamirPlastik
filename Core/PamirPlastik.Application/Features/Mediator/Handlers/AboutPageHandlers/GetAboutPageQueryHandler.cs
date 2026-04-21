using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.AboutPageQueries;
using PamirPlastik.Application.Interfaces; // IRepository buradan gelecek
using PamirPlastik.Domain.Entities; // Tablolarımız
using PamirPlastik.Dto.AboutDtos;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutPageHandlers
{
    public class GetAboutPageQueryHandler : IRequestHandler<GetAboutPageQuery, ResultAboutPageDto>
    {
        // 3 tablo için 3 ayrı Repository'yi enjekte ediyoruz kanka
        private readonly IRepository<About> _aboutRepository;
        private readonly IRepository<AboutFeature> _featureRepository;
        private readonly IRepository<AboutImage> _sliderRepository;

        public GetAboutPageQueryHandler(
            IRepository<About> aboutRepository,
            IRepository<AboutFeature> featureRepository,
            IRepository<AboutImage> sliderRepository)
        {
            _aboutRepository = aboutRepository;
            _featureRepository = featureRepository;
            _sliderRepository = sliderRepository;
        }

        public async Task<ResultAboutPageDto> Handle(GetAboutPageQuery request, CancellationToken cancellationToken)
        {
            // 1. Ana About kaydını çekiyoruz
            var abouts = await _aboutRepository.GetAllAsync();
            var about = abouts.FirstOrDefault(); // Veritabanındaki ilk Hakkımızda kaydını al

            if (about == null) return null;

            // 2. AboutID'ye bağlı olan Özellikleri (Features) çekiyoruz
            var allFeatures = await _featureRepository.GetAllAsync();
            var features = allFeatures.Where(x => x.AboutID == about.AboutID).ToList();

            // 3. AboutID'ye bağlı olan Resimleri (Sliders) çekiyoruz
            var allSliders = await _sliderRepository.GetAllAsync();
            var sliders = allSliders.Where(x => x.AboutID == about.AboutID).ToList();

            // Dili kontrol ediyoruz
            bool isTr = request.Language == "tr";

            // 4. Kamyonu (DTO'yu) dolduruyoruz
            var result = new ResultAboutPageDto
            {
                AboutDetail = new ResultAboutDto
                {
                    AboutID = about.AboutID,
                    StoryTitle = isTr ? about.StoryTitle_TR : about.StoryTitle_EN,
                    StorySubtitle = isTr ? about.StorySubtitle_TR : about.StorySubtitle_EN,
                    StoryParagraph1 = isTr ? about.StoryParagraph1_TR : about.StoryParagraph1_EN,
                    StoryParagraph2 = isTr ? about.StoryParagraph2_TR : about.StoryParagraph2_EN,
                    StoryQuote = isTr ? about.StoryQuote_TR : about.StoryQuote_EN,
                    StoryParagraph3 = isTr ? about.StoryParagraph3_TR : about.StoryParagraph3_EN,

                    FacilitySectionBadge = isTr ? about.FacilitySectionBadge_TR : about.FacilitySectionBadge_EN,
                    FacilitySectionTitle = isTr ? about.FacilitySectionTitle_TR : about.FacilitySectionTitle_EN,
                    Stat1Value = about.Stat1Value,
                    Stat1Label = isTr ? about.Stat1Label_TR : about.Stat1Label_EN,
                    Stat2Value = about.Stat2Value,
                    Stat2Label = isTr ? about.Stat2Label_TR : about.Stat2Label_EN,

                    VisionBadge = isTr ? about.VisionBadge_TR : about.VisionBadge_EN,
                    VisionText = isTr ? about.VisionText_TR : about.VisionText_EN,
                    MissionBadge = isTr ? about.MissionBadge_TR : about.MissionBadge_EN,
                    MissionText = isTr ? about.MissionText_TR : about.MissionText_EN,

                    MetaTitle = isTr ? about.MetaTitle_TR : about.MetaTitle_EN,
                    MetaDescription = isTr ? about.MetaDescription_TR : about.MetaDescription_EN
                },

                Features = features.Select(f => new ResultAboutFeatureDto
                {
                    AboutFeatureID = f.AboutFeatureID,
                    Order = f.Order,
                    Title = isTr ? f.Title_TR : f.Title_EN,
                    Description = isTr ? f.Description_TR : f.Description_EN,
                    IsActive = f.IsActive
                }).ToList(),

                SliderImages = sliders.Select(s => new ResultAboutSliderImageDto
                {
                    AboutSliderImageID = s.AboutSliderImageID,
                    ImagePath = s.ImagePath,
                    ImageAlt = isTr ? s.ImageAlt_TR : s.ImageAlt_EN,
                    Order = s.Order
                }).OrderBy(s => s.Order).ToList()
            };

            return result;
        }
    }
}