using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.JobApplicationQueries;
using PamirPlastik.Application.Features.Mediator.Results.JobApplicationResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace PamirPlastik.Application.Features.Mediator.Handlers.JobApplicationHandlers
{
    public class GetJobApplicationQueryHandler : IRequestHandler<GetJobApplicationQuery, List<GetJobApplicationQueryResult>>
    {
        private readonly IRepository<JobApplication> _repository;
        public GetJobApplicationQueryHandler(IRepository<JobApplication> repository) { _repository = repository; }
        public async Task<List<GetJobApplicationQueryResult>> Handle(GetJobApplicationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetJobApplicationQueryResult
            {
                JobApplicationID = x.JobApplicationID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Phone = x.Phone,
                Message = x.Message,
                CvPdfUrl = x.CvPdfUrl,
                ApplicationDate = x.ApplicationDate
            }).OrderByDescending(x => x.ApplicationDate).ToList();
        }
    }
}
