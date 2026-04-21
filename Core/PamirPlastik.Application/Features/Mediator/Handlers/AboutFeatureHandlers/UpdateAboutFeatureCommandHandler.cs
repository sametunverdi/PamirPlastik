using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutFeatureCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutFeatureHandlers
{
    public class UpdateAboutFeatureCommandHandler : IRequestHandler<UpdateAboutFeatureCommand>
    {
        private readonly IRepository<AboutFeature> _repository;
        public UpdateAboutFeatureCommandHandler(IRepository<AboutFeature> repository) { _repository = repository; }

        public async Task Handle(UpdateAboutFeatureCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AboutFeatureID);
            if (values != null)
            {
                values.Order = request.Order;
                values.Title_TR = request.Title_TR;
                values.Title_EN = request.Title_EN;
                values.Description_TR = request.Description_TR;
                values.Description_EN = request.Description_EN;
                values.IsActive = request.IsActive;
                await _repository.UpdateAsync(values);
            }
        }
    }
}