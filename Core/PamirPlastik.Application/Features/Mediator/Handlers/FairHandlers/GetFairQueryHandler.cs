using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.FairQueries;
using PamirPlastik.Application.Features.Mediator.Results.FairResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.FairHandlers
{
    public class GetFairQueryHandler : IRequestHandler<GetFairQuery, List<GetFairQueryResult>>
    {
        private readonly IRepository<Fair> _repository;
        public GetFairQueryHandler(IRepository<Fair> repository) { _repository = repository; }

        public async Task<List<GetFairQueryResult>> Handle(GetFairQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFairQueryResult
            {
                FairID = x.FairID,
                Name_TR = x.Name_TR,
                Description_TR = x.Description_TR,
                ImageAlt_TR = x.ImageAlt_TR,
                Name_EN = x.Name_EN,
                Description_EN = x.Description_EN,
                ImageAlt_EN = x.ImageAlt_EN,
                Location = x.Location,
                StandNo = x.StandNo,
                FairDate = x.FairDate,
                ImagePath1 = x.ImagePath1,
                ImagePath2 = x.ImagePath2,
                IsActive = x.IsActive
            }).OrderByDescending(x => x.FairDate).ToList(); // En güncel fuar en üstte gelsin kanka
        }
    }
}