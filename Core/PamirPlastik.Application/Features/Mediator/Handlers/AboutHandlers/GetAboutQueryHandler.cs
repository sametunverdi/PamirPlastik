using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.AboutQueries;
using PamirPlastik.Application.Features.Mediator.Results.AboutResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery, List<GetAboutQueryResult>>
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAboutQueryResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                StoryTitle_TR = x.StoryTitle_TR,
                StoryTitle_EN = x.StoryTitle_EN,
                StorySubtitle_TR = x.StorySubtitle_TR,
                StorySubtitle_EN = x.StorySubtitle_EN,
                StoryParagraph1_TR = x.StoryParagraph1_TR,
                StoryParagraph1_EN = x.StoryParagraph1_EN,
                StoryParagraph2_TR = x.StoryParagraph2_TR,
                StoryParagraph2_EN = x.StoryParagraph2_EN,
                StoryQuote_TR = x.StoryQuote_TR,
                StoryQuote_EN = x.StoryQuote_EN,
                StoryParagraph3_TR = x.StoryParagraph3_TR,
                StoryParagraph3_EN = x.StoryParagraph3_EN,
                FacilitySectionBadge_TR = x.FacilitySectionBadge_TR,
                FacilitySectionBadge_EN = x.FacilitySectionBadge_EN,
                FacilitySectionTitle_TR = x.FacilitySectionTitle_TR,
                FacilitySectionTitle_EN = x.FacilitySectionTitle_EN,
                Stat1Value = x.Stat1Value,
                Stat1Label_TR = x.Stat1Label_TR,
                Stat1Label_EN = x.Stat1Label_EN,
                Stat2Value = x.Stat2Value,
                Stat2Label_TR = x.Stat2Label_TR,
                Stat2Label_EN = x.Stat2Label_EN,
                VisionBadge_TR = x.VisionBadge_TR,
                VisionBadge_EN = x.VisionBadge_EN,
                VisionText_TR = x.VisionText_TR,
                VisionText_EN = x.VisionText_EN,
                VisionSubText_TR = x.VisionSubText_TR,
                VisionSubText_EN = x.VisionSubText_EN,
                MissionBadge_TR = x.MissionBadge_TR,
                MissionBadge_EN = x.MissionBadge_EN,
                MissionText_TR = x.MissionText_TR,
                MissionText_EN = x.MissionText_EN,
                MissionSubText_TR = x.MissionSubText_TR,
                MissionSubText_EN = x.MissionSubText_EN,
                CtaTitle_TR = x.CtaTitle_TR,
                CtaTitle_EN = x.CtaTitle_EN,
                CtaSubText_TR = x.CtaSubText_TR,
                CtaSubText_EN = x.CtaSubText_EN,
                MetaTitle_TR = x.MetaTitle_TR,
                MetaTitle_EN = x.MetaTitle_EN,
                MetaDescription_TR = x.MetaDescription_TR,
                MetaDescription_EN = x.MetaDescription_EN
            }).ToList();
        }
    }
}