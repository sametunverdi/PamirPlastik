using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ManufacturingFeatureCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingFeatureHandlers
{
    public class CreateManufacturingFeatureCommandHandler : IRequestHandler<CreateManufacturingFeatureCommand>
    {
        private readonly IRepository<ManufacturingFeature> _repository;
        public CreateManufacturingFeatureCommandHandler(IRepository<ManufacturingFeature> repository) { _repository = repository; }

        public async Task Handle(CreateManufacturingFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ManufacturingFeature
            {
                Title_TR = request.Title_TR,
                Description_TR = request.Description_TR,
                Title_EN = request.Title_EN,
                Description_EN = request.Description_EN,
                IconName = request.IconName,
                IsActive = request.IsActive
            });
        }
    }
}