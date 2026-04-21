using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutSliderImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutSliderImageHandlers
{
    public class RemoveAboutSliderImageCommandHandler : IRequestHandler<RemoveAboutSliderImageCommand>
    {
        private readonly IRepository<AboutImage> _repository;
        public RemoveAboutSliderImageCommandHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task Handle(RemoveAboutSliderImageCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null) { await _repository.RemoveAsync(value); }
        }
    }
}