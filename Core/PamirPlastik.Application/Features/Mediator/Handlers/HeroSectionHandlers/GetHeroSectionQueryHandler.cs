using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.HeroSectionQueries;
using PamirPlastik.Application.Features.Mediator.Results.HeroSectionResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroSectionHandlers
{
    public class GetHeroSectionQueryHandler : IRequestHandler<GetHeroSectionQuery, List<GetHeroSectionQueryResult>>
    {
        private readonly IRepository<HeroSection> _repository;
        public GetHeroSectionQueryHandler(IRepository<HeroSection> repository) { _repository = repository; }

        public async Task<List<GetHeroSectionQueryResult>> Handle(GetHeroSectionQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetHeroSectionQueryResult
            {
                HeroSectionID = x.HeroSectionID,
                BadgeText_TR = x.BadgeText_TR,
                TitleMain_TR = x.TitleMain_TR,
                TitleHighlight_TR = x.TitleHighlight_TR,
                TitleEnd_TR = x.TitleEnd_TR,
                Description_TR = x.Description_TR,
                PrimaryButtonText_TR = x.PrimaryButtonText_TR,
                SecondaryButtonText_TR = x.SecondaryButtonText_TR,
                BadgeText_EN = x.BadgeText_EN,
                TitleMain_EN = x.TitleMain_EN,
                TitleHighlight_EN = x.TitleHighlight_EN,
                TitleEnd_EN = x.TitleEnd_EN,
                Description_EN = x.Description_EN,
                PrimaryButtonText_EN = x.PrimaryButtonText_EN,
                SecondaryButtonText_EN = x.SecondaryButtonText_EN,
                PrimaryButtonUrl = x.PrimaryButtonUrl,
                SecondaryButtonUrl = x.SecondaryButtonUrl,
                ImagePath = x.ImagePath,
                ImageAlt_TR = x.ImageAlt_TR,
                ImageAlt_EN = x.ImageAlt_EN,
                IsActive = x.IsActive,
                MetaTitle_TR = x.MetaTitle_TR,
                MetaTitle_EN = x.MetaTitle_EN,
                MetaDescription_TR = x.MetaDescription_TR,
                MetaDescription_EN = x.MetaDescription_EN
            }).ToList();
        }
    }
}