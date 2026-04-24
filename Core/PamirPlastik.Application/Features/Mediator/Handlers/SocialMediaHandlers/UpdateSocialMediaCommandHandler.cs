using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.SocialMediaCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;
        public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository) => _repository = repository;

        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.SocialMediaID);
            value.PlatformName = request.PlatformName;
            value.IconClass = request.IconClass;
            value.Url = request.Url;
            value.IsActive = request.IsActive;
            await _repository.UpdateAsync(value);
        }
    }
}
