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
    public class CreateAboutFeatureCommandHandler : IRequestHandler<CreateAboutFeatureCommand>
    {
        private readonly IRepository<AboutFeature> _repository;
        public CreateAboutFeatureCommandHandler(IRepository<AboutFeature> repository) { _repository = repository; }

        public async Task Handle(CreateAboutFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AboutFeature
            {
                AboutId = request.AboutId,
                FeatureType = request.FeatureType,
                ValueOrIcon = request.ValueOrIcon,
                Title_TR = request.Title_TR,
                Title_EN = request.Title_EN,
                Description_TR = request.Description_TR,
                Description_EN = request.Description_EN,
                Order = request.Order
            });
        }
    }
}
