using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.AboutSliderImageQueries;
using PamirPlastik.Application.Features.Mediator.Results.AboutSliderImageResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutSliderImageHandlers
{
    public class GetAboutSliderImageByIdQueryHandler : IRequestHandler<GetAboutSliderImageByIdQuery, GetAboutSliderImageByIdQueryResult>
    {
        private readonly IRepository<AboutImage> _repository;
        public GetAboutSliderImageByIdQueryHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task<GetAboutSliderImageByIdQueryResult> Handle(GetAboutSliderImageByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value == null) return null;

            return new GetAboutSliderImageByIdQueryResult
            {
                AboutSliderImageID = value.AboutSliderImageID,
                ImagePath = value.ImagePath,
                ImageAlt_TR = value.ImageAlt_TR,
                ImageAlt_EN = value.ImageAlt_EN,
                Order = value.Order,
                IsActive = value.IsActive,
                AboutID = value.AboutID
            };
        }
    }
}