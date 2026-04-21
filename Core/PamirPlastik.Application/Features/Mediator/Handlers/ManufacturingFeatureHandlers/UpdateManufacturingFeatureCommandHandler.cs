using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ManufacturingFeatureCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingFeatureHandlers
{
    public class UpdateManufacturingFeatureCommandHandler : IRequestHandler<UpdateManufacturingFeatureCommand>
    {
        private readonly IRepository<ManufacturingFeature> _repository;
        public UpdateManufacturingFeatureCommandHandler(IRepository<ManufacturingFeature> repository) { _repository = repository; }

        public async Task Handle(UpdateManufacturingFeatureCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ManufacturingFeatureID);
            if (values != null)
            {
                values.Title_TR = request.Title_TR;
                values.Description_TR = request.Description_TR;
                values.Title_EN = request.Title_EN;
                values.Description_EN = request.Description_EN;
                values.IconName = request.IconName;
                values.IsActive = request.IsActive;
                await _repository.UpdateAsync(values);
            }
        }
    }
}