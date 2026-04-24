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
    public class RemoveAboutFeatureCommandHandler : IRequestHandler<RemoveAboutFeatureCommand>
    {
        private readonly IRepository<AboutFeature> _repository;
        public RemoveAboutFeatureCommandHandler(IRepository<AboutFeature> repository) { _repository = repository; }

        public async Task Handle(RemoveAboutFeatureCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            if (values != null)
            {
                await _repository.RemoveAsync(values);
            }
        }
    }
}
