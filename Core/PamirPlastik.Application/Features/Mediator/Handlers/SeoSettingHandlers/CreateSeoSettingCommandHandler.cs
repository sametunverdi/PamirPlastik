using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.SeoSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SeoSettingHandlers
{
    public class CreateSeoSettingCommandHandler : IRequestHandler<CreateSeoSettingCommand>
    {
        private readonly IRepository<SeoSetting> _repository;

        public CreateSeoSettingCommandHandler(IRepository<SeoSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSeoSettingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SeoSetting
            {
                PageName = request.PageName,
                MetaTitle_TR = request.MetaTitle_TR,
                MetaDescription_TR = request.MetaDescription_TR,
                MetaTitle_EN = request.MetaTitle_EN,
                MetaDescription_EN = request.MetaDescription_EN
            });
        }
    }
}