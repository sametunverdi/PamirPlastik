using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.SiteSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SiteSettingHandlers
{
    public class UpdateSiteSettingCommandHandler : IRequestHandler<UpdateSiteSettingCommand>
    {
        private readonly IRepository<SiteSetting> _repository;

        public UpdateSiteSettingCommandHandler(IRepository<SiteSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSiteSettingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.SiteSettingID);
            if (value != null)
            {
                value.LogoPath = request.LogoPath;
                value.SiteName_TR = request.SiteName_TR;
                value.SiteName_EN = request.SiteName_EN;
                value.Phone = request.Phone;
                value.Email = request.Email;
                value.Address_TR = request.Address_TR;
                value.Address_EN = request.Address_EN;
                value.Instagram = request.Instagram;
                value.Facebook = request.Facebook;
                value.Linkedin = request.Linkedin;
                value.Youtube = request.Youtube;

                await _repository.UpdateAsync(value);
            }
        }
    }
}