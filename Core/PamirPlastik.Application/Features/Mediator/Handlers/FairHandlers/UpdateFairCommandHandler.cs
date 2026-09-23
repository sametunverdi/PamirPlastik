using MediatR;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using PamirPlastik.Application.Features.Mediator.Commands.FairCommands;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.FairHandlers
{
    public class UpdateFairCommandHandler : IRequestHandler<UpdateFairCommand>
    {
        private readonly IRepository<Fair> _repository;
        public UpdateFairCommandHandler(IRepository<Fair> repository) { _repository = repository; }
        public async Task Handle(UpdateFairCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FairID);
            if(values != null) {
                values.Name = request.Name;
                values.Location = request.Location;
                values.Date = request.Date;
                values.Stand = request.Stand;
                values.Img1 = request.Img1;
                values.Img2 = request.Img2;
                values.IsFuture = request.IsFuture;
                await _repository.UpdateAsync(values);
            }
        }
    }
}
