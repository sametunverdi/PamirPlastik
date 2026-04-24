using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.AboutQueries;
using PamirPlastik.Application.Features.Mediator.Results.AboutResults;
using PamirPlastik.Application.Features.Mediator.Results.AboutFeatureResults;
using PamirPlastik.Application.Features.Mediator.Results.AboutImageResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery, GetAboutQueryResult>
    {
       
        private readonly IRepository<About> _aboutRepository;
        private readonly IRepository<AboutFeature> _featureRepository;
        private readonly IRepository<AboutImage> _imageRepository;

        public GetAboutQueryHandler(
            IRepository<About> aboutRepository,
            IRepository<AboutFeature> featureRepository,
            IRepository<AboutImage> imageRepository)
        {
            _aboutRepository = aboutRepository;
            _featureRepository = featureRepository;
            _imageRepository = imageRepository;
        }

        public async Task<GetAboutQueryResult> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            // 1. Ana Hakkımızda verisini çekiyoruz (Tablodaki tüm listeyi çekip ilkini alıyoruz)
            var abouts = await _aboutRepository.GetAllAsync();
            var values = abouts.FirstOrDefault();

            // Eğer veritabanı boşsa hata fırlatmasın diye boş sepet dönüyoruz
            if (values == null) return new GetAboutQueryResult();

            // 2. Alt tabloları çekiyoruz
            var allFeatures = await _featureRepository.GetAllAsync();
            var allImages = await _imageRepository.GetAllAsync();

            // 3. Sadece bu Hakkımızda ID'sine ait olan süreçleri ve resimleri filtreliyoruz
            var features = allFeatures.Where(x => x.AboutId == values.Id).ToList();
            var images = allImages.Where(x => x.AboutId == values.Id).ToList();

            // 4. Bütün verileri Result sepetine dolduruyoruz
            return new GetAboutQueryResult
            {
                Id = values.Id,
                SeoTitle_TR = values.SeoTitle_TR,
                SeoTitle_EN = values.SeoTitle_EN,
                SeoDescription_TR = values.SeoDescription_TR,
                SeoDescription_EN = values.SeoDescription_EN,
                MainTitle_TR = values.MainTitle_TR,
                MainTitle_EN = values.MainTitle_EN,
                SubTitle_TR = values.SubTitle_TR,
                SubTitle_EN = values.SubTitle_EN,
                Description1_TR = values.Description1_TR,
                Description1_EN = values.Description1_EN,
                Description2_TR = values.Description2_TR,
                Description2_EN = values.Description2_EN,
                HighlightQuote_TR = values.HighlightQuote_TR,
                HighlightQuote_EN = values.HighlightQuote_EN,
                VisionTitle_TR = values.VisionTitle_TR,
                VisionTitle_EN = values.VisionTitle_EN,
                VisionDescription_TR = values.VisionDescription_TR,
                VisionDescription_EN = values.VisionDescription_EN,
                MissionTitle_TR = values.MissionTitle_TR,
                MissionTitle_EN = values.MissionTitle_EN,
                MissionDescription_TR = values.MissionDescription_TR,
                MissionDescription_EN = values.MissionDescription_EN,

                // Listeleri dönüştürüyoruz
                Features = features.Select(f => new GetAboutFeatureQueryResult
                {
                    FeatureType = f.FeatureType,
                    ValueOrIcon = f.ValueOrIcon,
                    Title_TR = f.Title_TR,
                    Title_EN = f.Title_EN,
                    Description_TR = f.Description_TR,
                    Description_EN = f.Description_EN
                }).ToList(),

                Images = images.Select(i => new GetAboutImageQueryResult
                {
                    ImageUrl = i.ImageUrl,
                    AltText_TR = i.AltText_TR,
                    AltText_EN = i.AltText_EN
                }).ToList()
            };
        }
    }
}