using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutSliderImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutSliderImageHandlers
{
    public class CreateAboutSliderImageCommandHandler : IRequestHandler<CreateAboutSliderImageCommand>
    {
        private readonly IRepository<AboutImage> _repository;
        public CreateAboutSliderImageCommandHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task Handle(CreateAboutSliderImageCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AboutImage
            {
                ImagePath = request.ImagePath,
                ImageAlt_TR = request.ImageAlt_TR,
                ImageAlt_EN = request.ImageAlt_EN,
                Order = request.Order,
                IsActive = request.IsActive
            });
        }
    }
}