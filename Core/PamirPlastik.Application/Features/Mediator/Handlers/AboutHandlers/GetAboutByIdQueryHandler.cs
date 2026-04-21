using MediatR; 
using PamirPlastik.Application.Features.Mediator.Queries.AboutQueries;
using PamirPlastik.Application.Features.Mediator.Results.AboutResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);

            if (values == null) return null;

            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                // Hikaye Bölümü
                StoryTitle_TR = values.StoryTitle_TR,
                StoryTitle_EN = values.StoryTitle_EN,
                StorySubtitle_TR = values.StorySubtitle_TR,
                StorySubtitle_EN = values.StorySubtitle_EN,
                StoryParagraph1_TR = values.StoryParagraph1_TR,
                StoryParagraph1_EN = values.StoryParagraph1_EN,
                StoryParagraph2_TR = values.StoryParagraph2_TR,
                StoryParagraph2_EN = values.StoryParagraph2_EN,
                StoryQuote_TR = values.StoryQuote_TR,
                StoryQuote_EN = values.StoryQuote_EN,
                StoryParagraph3_TR = values.StoryParagraph3_TR,
                StoryParagraph3_EN = values.StoryParagraph3_EN,

                // Tesis & İstatistik
                FacilitySectionBadge_TR = values.FacilitySectionBadge_TR,
                FacilitySectionBadge_EN = values.FacilitySectionBadge_EN,
                FacilitySectionTitle_TR = values.FacilitySectionTitle_TR,
                FacilitySectionTitle_EN = values.FacilitySectionTitle_EN,
                Stat1Value = values.Stat1Value,
                Stat1Label_TR = values.Stat1Label_TR,
                Stat1Label_EN = values.Stat1Label_EN,
                Stat2Value = values.Stat2Value,
                Stat2Label_TR = values.Stat2Label_TR,
                Stat2Label_EN = values.Stat2Label_EN,

                // Vizyon & Misyon
                VisionBadge_TR = values.VisionBadge_TR,
                VisionBadge_EN = values.VisionBadge_EN,
                VisionText_TR = values.VisionText_TR,
                VisionText_EN = values.VisionText_EN,
                VisionSubText_TR = values.VisionSubText_TR,
                VisionSubText_EN = values.VisionSubText_EN,
                MissionBadge_TR = values.MissionBadge_TR,
                MissionBadge_EN = values.MissionBadge_EN,
                MissionText_TR = values.MissionText_TR,
                MissionText_EN = values.MissionText_EN,
                MissionSubText_TR = values.MissionSubText_TR,
                MissionSubText_EN = values.MissionSubText_EN,

                // CTA & SEO
                CtaTitle_TR = values.CtaTitle_TR,
                CtaTitle_EN = values.CtaTitle_EN,
                CtaSubText_TR = values.CtaSubText_TR,
                CtaSubText_EN = values.CtaSubText_EN,
                MetaTitle_TR = values.MetaTitle_TR,
                MetaTitle_EN = values.MetaTitle_EN,
                MetaDescription_TR = values.MetaDescription_TR,
                MetaDescription_EN = values.MetaDescription_EN
            };
        }
    }
}