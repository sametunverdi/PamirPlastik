using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutFeatureCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutFeatureHandlers
{
    public class UpdateAboutFeatureCommandHandler : IRequestHandler<UpdateAboutFeatureCommand>
    {
        private readonly IRepository<AboutFeature> _repository;
        public UpdateAboutFeatureCommandHandler(IRepository<AboutFeature> repository) { _repository = repository; }

        public async Task Handle(UpdateAboutFeatureCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            if (values != null)
            {
                values.AboutId = request.AboutId;
                values.FeatureType = request.FeatureType;
                values.ValueOrIcon = request.ValueOrIcon;
                values.Title_TR = request.Title_TR;
                values.Title_EN = request.Title_EN;
                values.Description_TR = request.Description_TR;
                values.Description_EN = request.Description_EN;
                values.Order = request.Order;
                await _repository.UpdateAsync(values);
            }
        }
    }
}
