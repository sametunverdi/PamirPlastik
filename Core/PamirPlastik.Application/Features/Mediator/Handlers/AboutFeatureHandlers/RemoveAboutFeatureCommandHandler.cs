using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutFeatureCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutFeatureHandlers
{
    public class RemoveAboutFeatureCommandHandler : IRequestHandler<RemoveAboutFeatureCommand>
    {
        private readonly IRepository<AboutFeature> _repository;
        public RemoveAboutFeatureCommandHandler(IRepository<AboutFeature> repository) { _repository = repository; }

        public async Task Handle(RemoveAboutFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null) { await _repository.RemoveAsync(value); }
        }
    }
}