using MediatR;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using PamirPlastik.Application.Features.Mediator.Commands.FairCommands;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.FairHandlers
{
    public class CreateFairCommandHandler : IRequestHandler<CreateFairCommand>
    {
        private readonly IRepository<Fair> _repository;
        public CreateFairCommandHandler(IRepository<Fair> repository) { _repository = repository; }
        public async Task Handle(CreateFairCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Fair
            {
                Name = request.Name,
                Location = request.Location,
                Date = request.Date,
                Stand = request.Stand,
                Img1 = request.Img1,
                Img2 = request.Img2,
                IsFuture = request.IsFuture
            });
        }
    }
}
