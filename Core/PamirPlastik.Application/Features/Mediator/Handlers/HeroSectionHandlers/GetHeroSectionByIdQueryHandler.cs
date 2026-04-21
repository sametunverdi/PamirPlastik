using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.HeroSectionQueries;
using PamirPlastik.Application.Features.Mediator.Results.HeroSectionResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroSectionHandlers
{
    public class GetHeroSectionByIdQueryHandler : IRequestHandler<GetHeroSectionByIdQuery, GetHeroSectionByIdQueryResult>
    {
        private readonly IRepository<HeroSection> _repository;
        public GetHeroSectionByIdQueryHandler(IRepository<HeroSection> repository) { _repository = repository; }

        public async Task<GetHeroSectionByIdQueryResult> Handle(GetHeroSectionByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetHeroSectionByIdQueryResult
            {
                HeroSectionID = value.HeroSectionID,
                BadgeText_TR = value.BadgeText_TR,
                TitleMain_TR = value.TitleMain_TR,
                TitleHighlight_TR = value.TitleHighlight_TR,
                TitleEnd_TR = value.TitleEnd_TR,
                Description_TR = value.Description_TR,
                PrimaryButtonText_TR = value.PrimaryButtonText_TR,
                SecondaryButtonText_TR = value.SecondaryButtonText_TR,
                BadgeText_EN = value.BadgeText_EN,
                TitleMain_EN = value.TitleMain_EN,
                TitleHighlight_EN = value.TitleHighlight_EN,
                TitleEnd_EN = value.TitleEnd_EN,
                Description_EN = value.Description_EN,
                PrimaryButtonText_EN = value.PrimaryButtonText_EN,
                SecondaryButtonText_EN = value.SecondaryButtonText_EN,
                PrimaryButtonUrl = value.PrimaryButtonUrl,
                SecondaryButtonUrl = value.SecondaryButtonUrl,
                ImagePath = value.ImagePath,
                ImageAlt_TR = value.ImageAlt_TR,
                ImageAlt_EN = value.ImageAlt_EN,
                IsActive = value.IsActive,
                MetaTitle_TR = value.MetaTitle_TR,
                MetaTitle_EN = value.MetaTitle_EN,
                MetaDescription_TR = value.MetaDescription_TR,
                MetaDescription_EN = value.MetaDescription_EN
            };
        }
    }
}