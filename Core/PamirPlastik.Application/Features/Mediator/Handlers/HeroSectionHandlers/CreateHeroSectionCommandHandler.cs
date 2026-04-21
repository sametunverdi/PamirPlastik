using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroSectionCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroSectionHandlers
{
    public class CreateHeroSectionCommandHandler : IRequestHandler<CreateHeroSectionCommand>
    {
        private readonly IRepository<HeroSection> _repository;
        public CreateHeroSectionCommandHandler(IRepository<HeroSection> repository) { _repository = repository; }

        public async Task Handle(CreateHeroSectionCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new HeroSection
            {
                BadgeText_TR = request.BadgeText_TR,
                TitleMain_TR = request.TitleMain_TR,
                TitleHighlight_TR = request.TitleHighlight_TR,
                TitleEnd_TR = request.TitleEnd_TR,
                Description_TR = request.Description_TR,
                PrimaryButtonText_TR = request.PrimaryButtonText_TR,
                SecondaryButtonText_TR = request.SecondaryButtonText_TR,
                BadgeText_EN = request.BadgeText_EN,
                TitleMain_EN = request.TitleMain_EN,
                TitleHighlight_EN = request.TitleHighlight_EN,
                TitleEnd_EN = request.TitleEnd_EN,
                Description_EN = request.Description_EN,
                PrimaryButtonText_EN = request.PrimaryButtonText_EN,
                SecondaryButtonText_EN = request.SecondaryButtonText_EN,
                PrimaryButtonUrl = request.PrimaryButtonUrl,
                SecondaryButtonUrl = request.SecondaryButtonUrl,
                ImagePath = request.ImagePath,
                ImageAlt_TR = request.ImageAlt_TR,
                ImageAlt_EN = request.ImageAlt_EN,
                IsActive = request.IsActive,
                MetaTitle_TR = request.MetaTitle_TR,
                MetaTitle_EN = request.MetaTitle_EN,
                MetaDescription_TR = request.MetaDescription_TR,
                MetaDescription_EN = request.MetaDescription_EN
            });
        }
    }
}