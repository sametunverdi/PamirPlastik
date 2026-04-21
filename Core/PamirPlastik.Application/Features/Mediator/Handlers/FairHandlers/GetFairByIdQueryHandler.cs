using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.FairQueries;
using PamirPlastik.Application.Features.Mediator.Results.FairResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.FairHandlers
{
    public class GetFairByIdQueryHandler : IRequestHandler<GetFairByIdQuery, GetFairByIdQueryResult>
    {
        private readonly IRepository<Fair> _repository;
        public GetFairByIdQueryHandler(IRepository<Fair> repository) { _repository = repository; }

        public async Task<GetFairByIdQueryResult> Handle(GetFairByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetFairByIdQueryResult
            {
                FairID = value.FairID,
                Name_TR = value.Name_TR,
                Description_TR = value.Description_TR,
                ImageAlt_TR = value.ImageAlt_TR,
                Name_EN = value.Name_EN,
                Description_EN = value.Description_EN,
                ImageAlt_EN = value.ImageAlt_EN,
                Location = value.Location,
                StandNo = value.StandNo,
                FairDate = value.FairDate,
                ImagePath1 = value.ImagePath1,
                ImagePath2 = value.ImagePath2,
                IsActive = value.IsActive
            };
        }
    }
}