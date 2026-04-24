using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.AboutImageQueries;
using PamirPlastik.Application.Features.Mediator.Results.AboutImageResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutImageHandlers
{
    public class GetAboutImageQueryHandler : IRequestHandler<GetAboutImageQuery, List<GetAboutImageQueryResult>>
    {
        private readonly IRepository<AboutImage> _repository;
        public GetAboutImageQueryHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task<List<GetAboutImageQueryResult>> Handle(GetAboutImageQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutImageQueryResult
            {
                Id = x.Id,
                AboutId = x.AboutId,
                ImageUrl = x.ImageUrl,
                AltText_TR = x.AltText_TR,
                AltText_EN = x.AltText_EN,
                Order = x.Order
            }).ToList();
        }
    }
}
