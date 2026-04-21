using MediatR; 
using PamirPlastik.Application.Features.Mediator.Commands.AboutCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading; 
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new About
            {
                // Hikaye Bölümü
                StoryTitle_TR = request.StoryTitle_TR,
                StoryTitle_EN = request.StoryTitle_EN,
                StorySubtitle_TR = request.StorySubtitle_TR,
                StorySubtitle_EN = request.StorySubtitle_EN,
                StoryParagraph1_TR = request.StoryParagraph1_TR,
                StoryParagraph1_EN = request.StoryParagraph1_EN,
                StoryParagraph2_TR = request.StoryParagraph2_TR,
                StoryParagraph2_EN = request.StoryParagraph2_EN,
                StoryQuote_TR = request.StoryQuote_TR,
                StoryQuote_EN = request.StoryQuote_EN,
                StoryParagraph3_TR = request.StoryParagraph3_TR,
                StoryParagraph3_EN = request.StoryParagraph3_EN,

                // Tesis Bölümü
                FacilitySectionBadge_TR = request.FacilitySectionBadge_TR,
                FacilitySectionBadge_EN = request.FacilitySectionBadge_EN,
                FacilitySectionTitle_TR = request.FacilitySectionTitle_TR,
                FacilitySectionTitle_EN = request.FacilitySectionTitle_EN,

                // İstatistikler
                Stat1Value = request.Stat1Value,
                Stat1Label_TR = request.Stat1Label_TR,
                Stat1Label_EN = request.Stat1Label_EN,
                Stat2Value = request.Stat2Value,
                Stat2Label_TR = request.Stat2Label_TR,
                Stat2Label_EN = request.Stat2Label_EN,

                // Vizyon
                VisionBadge_TR = request.VisionBadge_TR,
                VisionBadge_EN = request.VisionBadge_EN,
                VisionText_TR = request.VisionText_TR,
                VisionText_EN = request.VisionText_EN,
                VisionSubText_TR = request.VisionSubText_TR,
                VisionSubText_EN = request.VisionSubText_EN,

                // Misyon
                MissionBadge_TR = request.MissionBadge_TR,
                MissionBadge_EN = request.MissionBadge_EN,
                MissionText_TR = request.MissionText_TR,
                MissionText_EN = request.MissionText_EN,
                MissionSubText_TR = request.MissionSubText_TR,
                MissionSubText_EN = request.MissionSubText_EN,

                // CTA & SEO
                CtaTitle_TR = request.CtaTitle_TR,
                CtaTitle_EN = request.CtaTitle_EN,
                CtaSubText_TR = request.CtaSubText_TR,
                CtaSubText_EN = request.CtaSubText_EN,
                MetaTitle_TR = request.MetaTitle_TR,
                MetaTitle_EN = request.MetaTitle_EN,
                MetaDescription_TR = request.MetaDescription_TR,
                MetaDescription_EN = request.MetaDescription_EN
            });
        }
    }
}