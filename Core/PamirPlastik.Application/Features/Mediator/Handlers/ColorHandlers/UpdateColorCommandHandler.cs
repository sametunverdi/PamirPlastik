using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ColorCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ColorHandlers
{
    public class UpdateColorCommandHandler : IRequestHandler<UpdateColorCommand>
    {
        private readonly IRepository<Color> _repository;

        public UpdateColorCommandHandler(IRepository<Color> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateColorCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ColorID);
            values.Name_TR = request.Name_TR;
            values.Name_EN = request.Name_EN;
            values.HexCode = request.HexCode;
            await _repository.UpdateAsync(values);
        }
    }
}