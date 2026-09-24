using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.JobApplicationCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
namespace PamirPlastik.Application.Features.Mediator.Handlers.JobApplicationHandlers
{
    public class CreateJobApplicationCommandHandler : IRequestHandler<CreateJobApplicationCommand>
    {
        private readonly IRepository<JobApplication> _repository;
        public CreateJobApplicationCommandHandler(IRepository<JobApplication> repository) { _repository = repository; }
        public async Task Handle(CreateJobApplicationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new JobApplication
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                Message = request.Message,
                CvPdfUrl = request.CvPdfUrl,
                ApplicationDate = request.ApplicationDate
            });
        }
    }
}
