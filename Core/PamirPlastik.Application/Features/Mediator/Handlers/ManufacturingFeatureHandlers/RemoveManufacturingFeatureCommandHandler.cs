using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ManufacturingFeatureCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingFeatureHandlers
{
    public class RemoveManufacturingFeatureCommandHandler : IRequestHandler<RemoveManufacturingFeatureCommand>
    {
        private readonly IRepository<ManufacturingFeature> _repository;
        public RemoveManufacturingFeatureCommandHandler(IRepository<ManufacturingFeature> repository) { _repository = repository; }

        public async Task Handle(RemoveManufacturingFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null) { await _repository.RemoveAsync(value); }
        }
    }
}