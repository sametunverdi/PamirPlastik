using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ManufacturingSectionCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingSectionHandlers
{
    public class RemoveManufacturingSectionCommandHandler : IRequestHandler<RemoveManufacturingSectionCommand>
    {
        private readonly IRepository<ManufacturingSection> _repository;
        public RemoveManufacturingSectionCommandHandler(IRepository<ManufacturingSection> repository) { _repository = repository; }

        public async Task Handle(RemoveManufacturingSectionCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null) { await _repository.RemoveAsync(value); }
        }
    }
}