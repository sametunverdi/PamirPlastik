using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AboutID);

            if (values != null)
            {
                values.StoryTitle_TR = request.StoryTitle_TR;
                values.StoryTitle_EN = request.StoryTitle_EN;
                values.StorySubtitle_TR = request.StorySubtitle_TR;
                values.StorySubtitle_EN = request.StorySubtitle_EN;
                values.StoryParagraph1_TR = request.StoryParagraph1_TR;
                values.StoryParagraph1_EN = request.StoryParagraph1_EN;
                values.StoryParagraph2_TR = request.StoryParagraph2_TR;
                values.StoryParagraph2_EN = request.StoryParagraph2_EN;
                values.StoryQuote_TR = request.StoryQuote_TR;
                values.StoryQuote_EN = request.StoryQuote_EN;
                values.StoryParagraph3_TR = request.StoryParagraph3_TR;
                values.StoryParagraph3_EN = request.StoryParagraph3_EN;
                values.FacilitySectionBadge_TR = request.FacilitySectionBadge_TR;
                values.FacilitySectionBadge_EN = request.FacilitySectionBadge_EN;
                values.FacilitySectionTitle_TR = request.FacilitySectionTitle_TR;
                values.FacilitySectionTitle_EN = request.FacilitySectionTitle_EN;
                values.Stat1Value = request.Stat1Value;
                values.Stat1Label_TR = request.Stat1Label_TR;
                values.Stat1Label_EN = request.Stat1Label_EN;
                values.Stat2Value = request.Stat2Value;
                values.Stat2Label_TR = request.Stat2Label_TR;
                values.Stat2Label_EN = request.Stat2Label_EN;
                values.VisionBadge_TR = request.VisionBadge_TR;
                values.VisionBadge_EN = request.VisionBadge_EN;
                values.VisionText_TR = request.VisionText_TR;
                values.VisionText_EN = request.VisionText_EN;
                values.VisionSubText_TR = request.VisionSubText_TR;
                values.VisionSubText_EN = request.VisionSubText_EN;
                values.MissionBadge_TR = request.MissionBadge_TR;
                values.MissionBadge_EN = request.MissionBadge_EN;
                values.MissionText_TR = request.MissionText_TR;
                values.MissionText_EN = request.MissionText_EN;
                values.MissionSubText_TR = request.MissionSubText_TR;
                values.MissionSubText_EN = request.MissionSubText_EN;
                values.CtaTitle_TR = request.CtaTitle_TR;
                values.CtaTitle_EN = request.CtaTitle_EN;
                values.CtaSubText_TR = request.CtaSubText_TR;
                values.CtaSubText_EN = request.CtaSubText_EN;
                values.MetaTitle_TR = request.MetaTitle_TR;
                values.MetaTitle_EN = request.MetaTitle_EN;
                values.MetaDescription_TR = request.MetaDescription_TR;
                values.MetaDescription_EN = request.MetaDescription_EN;

                await _repository.UpdateAsync(values);
            }
        }
    }
}