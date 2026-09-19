using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ColorCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ColorHandlers
{
    public class RemoveColorCommandHandler : IRequestHandler<RemoveColorCommand>
    {
        private readonly IRepository<Color> _repository;

        public RemoveColorCommandHandler(IRepository<Color> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveColorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}