using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.JobApplicationQueries;
using PamirPlastik.Application.Features.Mediator.Results.JobApplicationResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
namespace PamirPlastik.Application.Features.Mediator.Handlers.JobApplicationHandlers
{
    public class GetJobApplicationByIdQueryHandler : IRequestHandler<GetJobApplicationByIdQuery, GetJobApplicationByIdQueryResult>
    {
        private readonly IRepository<JobApplication> _repository;
        public GetJobApplicationByIdQueryHandler(IRepository<JobApplication> repository) { _repository = repository; }
        public async Task<GetJobApplicationByIdQueryResult> Handle(GetJobApplicationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetJobApplicationByIdQueryResult
            {
                JobApplicationID = values.JobApplicationID,
                FirstName = values.FirstName,
                LastName = values.LastName,
                Email = values.Email,
                Phone = values.Phone,
                Message = values.Message,
                CvPdfUrl = values.CvPdfUrl,
                ApplicationDate = values.ApplicationDate
            };
        }
    }
}
