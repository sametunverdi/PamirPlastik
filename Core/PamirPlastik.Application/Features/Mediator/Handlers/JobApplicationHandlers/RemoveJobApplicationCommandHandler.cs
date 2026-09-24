using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.JobApplicationCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
namespace PamirPlastik.Application.Features.Mediator.Handlers.JobApplicationHandlers
{
    public class RemoveJobApplicationCommandHandler : IRequestHandler<RemoveJobApplicationCommand>
    {
        private readonly IRepository<JobApplication> _repository;
        public RemoveJobApplicationCommandHandler(IRepository<JobApplication> repository) { _repository = repository; }
        public async Task Handle(RemoveJobApplicationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
