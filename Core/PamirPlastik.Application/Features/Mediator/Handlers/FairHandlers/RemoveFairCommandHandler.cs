using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.FairCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.FairHandlers
{
    public class RemoveFairCommandHandler : IRequestHandler<RemoveFairCommand>
    {
        private readonly IRepository<Fair> _repository;
        public RemoveFairCommandHandler(IRepository<Fair> repository) { _repository = repository; }

        public async Task Handle(RemoveFairCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null) { await _repository.RemoveAsync(value); }
        }
    }
}