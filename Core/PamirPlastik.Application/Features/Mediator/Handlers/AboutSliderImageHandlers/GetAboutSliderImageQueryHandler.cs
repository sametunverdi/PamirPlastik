using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.AboutSliderImageQueries;
using PamirPlastik.Application.Features.Mediator.Results.AboutSliderImageResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutSliderImageHandlers
{
    public class GetAboutSliderImageQueryHandler : IRequestHandler<GetAboutSliderImageQuery, List<GetAboutSliderImageQueryResult>>
    {
        private readonly IRepository<AboutImage> _repository;
        public GetAboutSliderImageQueryHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task<List<GetAboutSliderImageQueryResult>> Handle(GetAboutSliderImageQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutSliderImageQueryResult
            {
                AboutSliderImageID = x.AboutSliderImageID,
                ImagePath = x.ImagePath,
                ImageAlt_TR = x.ImageAlt_TR,
                ImageAlt_EN = x.ImageAlt_EN,
                Order = x.Order,
                IsActive = x.IsActive,
                AboutID = x.AboutID
            }).OrderBy(x => x.Order).ToList();
        }
    }
}