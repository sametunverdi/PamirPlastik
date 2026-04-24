using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutImageHandlers
{
    public class RemoveAboutImageCommandHandler : IRequestHandler<RemoveAboutImageCommand>
    {
        private readonly IRepository<AboutImage> _repository;
        public RemoveAboutImageCommandHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task Handle(RemoveAboutImageCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            if (values != null)
            {
                await _repository.RemoveAsync(values);
            }
        }
    }
}
