using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroSectionCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroSectionHandlers
{
    public class UpdateHeroSectionCommandHandler : IRequestHandler<UpdateHeroSectionCommand>
    {
        private readonly IRepository<HeroSection> _repository;
        public UpdateHeroSectionCommandHandler(IRepository<HeroSection> repository) { _repository = repository; }

        public async Task Handle(UpdateHeroSectionCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.HeroSectionID);
            if (values != null)
            {
                values.BadgeText_TR = request.BadgeText_TR;
                values.TitleMain_TR = request.TitleMain_TR;
                values.TitleHighlight_TR = request.TitleHighlight_TR;
                values.TitleEnd_TR = request.TitleEnd_TR;
                values.Description_TR = request.Description_TR;
                values.PrimaryButtonText_TR = request.PrimaryButtonText_TR;
                values.SecondaryButtonText_TR = request.SecondaryButtonText_TR;
                values.BadgeText_EN = request.BadgeText_EN;
                values.TitleMain_EN = request.TitleMain_EN;
                values.TitleHighlight_EN = request.TitleHighlight_EN;
                values.TitleEnd_EN = request.TitleEnd_EN;
                values.Description_EN = request.Description_EN;
                values.PrimaryButtonText_EN = request.PrimaryButtonText_EN;
                values.SecondaryButtonText_EN = request.SecondaryButtonText_EN;
                values.PrimaryButtonUrl = request.PrimaryButtonUrl;
                values.SecondaryButtonUrl = request.SecondaryButtonUrl;
                values.ImagePath = request.ImagePath;
                values.ImageAlt_TR = request.ImageAlt_TR;
                values.ImageAlt_EN = request.ImageAlt_EN;
                values.IsActive = request.IsActive;
                values.MetaTitle_TR = request.MetaTitle_TR;
                values.MetaTitle_EN = request.MetaTitle_EN;
                values.MetaDescription_TR = request.MetaDescription_TR;
                values.MetaDescription_EN = request.MetaDescription_EN;

                await _repository.UpdateAsync(values);
            }
        }
    }
}