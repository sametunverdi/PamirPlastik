using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutSliderImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutSliderImageHandlers
{
    public class UpdateAboutSliderImageCommandHandler : IRequestHandler<UpdateAboutSliderImageCommand>
    {
        private readonly IRepository<AboutImage> _repository;
        public UpdateAboutSliderImageCommandHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task Handle(UpdateAboutSliderImageCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AboutSliderImageID);
            if (values != null)
            {
                values.ImagePath = request.ImagePath;
                values.ImageAlt_TR = request.ImageAlt_TR;
                values.ImageAlt_EN = request.ImageAlt_EN;
                values.Order = request.Order;
                values.IsActive = request.IsActive;
                await _repository.UpdateAsync(values);
            }
        }
    }
}