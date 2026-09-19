using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ColorCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ColorHandlers
{
    public class CreateColorCommandHandler : IRequestHandler<CreateColorCommand>
    {
        private readonly IRepository<Color> _repository;

        public CreateColorCommandHandler(IRepository<Color> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateColorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Color
            {
                Name_TR = request.Name_TR,
                Name_EN = request.Name_EN,
                HexCode = request.HexCode
            });
        }
    }
}