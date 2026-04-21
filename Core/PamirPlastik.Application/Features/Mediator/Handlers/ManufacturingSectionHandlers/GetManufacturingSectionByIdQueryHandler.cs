using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ManufacturingSectionQueries;
using PamirPlastik.Application.Features.Mediator.Results.ManufacturingSectionResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingSectionHandlers
{
    public class GetManufacturingSectionByIdQueryHandler : IRequestHandler<GetManufacturingSectionByIdQuery, GetManufacturingSectionByIdQueryResult>
    {
        private readonly IRepository<ManufacturingSection> _repository;

        public GetManufacturingSectionByIdQueryHandler(IRepository<ManufacturingSection> repository)
        {
            _repository = repository;
        }

        public async Task<GetManufacturingSectionByIdQueryResult> Handle(GetManufacturingSectionByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            if (value == null) return null;

            return new GetManufacturingSectionByIdQueryResult
            {
                ManufacturingSectionID = value.ManufacturingSectionID,
                SubTitle_TR = value.SubTitle_TR,
                TitleMain_TR = value.TitleMain_TR,
                TitleHighlight_TR = value.TitleHighlight_TR,
                Description_TR = value.Description_TR,
                ButtonText_TR = value.ButtonText_TR,
                SubTitle_EN = value.SubTitle_EN,
                TitleMain_EN = value.TitleMain_EN,
                TitleHighlight_EN = value.TitleHighlight_EN,
                Description_EN = value.Description_EN,
                ButtonText_EN = value.ButtonText_EN,
                ButtonUrl = value.ButtonUrl,
                ImagePath = value.ImagePath,
                ImageAlt_TR = value.ImageAlt_TR,
                ImageAlt_EN = value.ImageAlt_EN,
                StatValue = value.StatValue,
                StatLabel_TR = value.StatLabel_TR,
                StatLabel_EN = value.StatLabel_EN,
                IsActive = value.IsActive
            };
        }
    }
}