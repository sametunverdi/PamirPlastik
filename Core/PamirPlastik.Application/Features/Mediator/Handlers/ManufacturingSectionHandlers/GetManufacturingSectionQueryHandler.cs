using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ManufacturingSectionQueries;
using PamirPlastik.Application.Features.Mediator.Results.ManufacturingSectionResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingSectionHandlers
{
    public class GetManufacturingSectionQueryHandler : IRequestHandler<GetManufacturingSectionQuery, List<GetManufacturingSectionQueryResult>>
    {
        private readonly IRepository<ManufacturingSection> _repository;
        public GetManufacturingSectionQueryHandler(IRepository<ManufacturingSection> repository) { _repository = repository; }

        public async Task<List<GetManufacturingSectionQueryResult>> Handle(GetManufacturingSectionQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetManufacturingSectionQueryResult
            {
                ManufacturingSectionID = x.ManufacturingSectionID,
                SubTitle_TR = x.SubTitle_TR,
                TitleMain_TR = x.TitleMain_TR,
                TitleHighlight_TR = x.TitleHighlight_TR,
                Description_TR = x.Description_TR,
                ButtonText_TR = x.ButtonText_TR,
                SubTitle_EN = x.SubTitle_EN,
                TitleMain_EN = x.TitleMain_EN,
                TitleHighlight_EN = x.TitleHighlight_EN,
                Description_EN = x.Description_EN,
                ButtonText_EN = x.ButtonText_EN,
                ButtonUrl = x.ButtonUrl,
                ImagePath = x.ImagePath,
                ImageAlt_TR = x.ImageAlt_TR,
                ImageAlt_EN = x.ImageAlt_EN,
                StatValue = x.StatValue,
                StatLabel_TR = x.StatLabel_TR,
                StatLabel_EN = x.StatLabel_EN,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}