using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.SocialMediaQueries;
using PamirPlastik.Application.Features.Mediator.Results.SocialMediaResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;
        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository) => _repository = repository;

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResult
            {
                SocialMediaID = value.SocialMediaID,
                PlatformName = value.PlatformName,
                IconClass = value.IconClass,
                Url = value.Url,
                IsActive = value.IsActive
            };
        }
    }
}
