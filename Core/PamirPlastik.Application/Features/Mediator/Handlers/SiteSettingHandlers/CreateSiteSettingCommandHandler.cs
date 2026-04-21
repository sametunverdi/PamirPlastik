using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.SiteSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SiteSettingHandlers
{
    public class CreateSiteSettingCommandHandler : IRequestHandler<CreateSiteSettingCommand>
    {
        private readonly IRepository<SiteSetting> _repository;

        public CreateSiteSettingCommandHandler(IRepository<SiteSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSiteSettingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SiteSetting
            {
                LogoPath = request.LogoPath,
                SiteName_TR = request.SiteName_TR,
                SiteName_EN = request.SiteName_EN,
                Phone = request.Phone,
                Email = request.Email,
                Address_TR = request.Address_TR,
                Address_EN = request.Address_EN,
                Instagram = request.Instagram,
                Facebook = request.Facebook,
                Linkedin = request.Linkedin,
                Youtube = request.Youtube
            });
        }
    }
}