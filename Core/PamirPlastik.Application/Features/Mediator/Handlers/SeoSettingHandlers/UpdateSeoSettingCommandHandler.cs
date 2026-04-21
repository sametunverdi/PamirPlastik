using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.SeoSettingCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.SeoSettingHandlers
{
    public class UpdateSeoSettingCommandHandler : IRequestHandler<UpdateSeoSettingCommand>
    {
        private readonly IRepository<SeoSetting> _repository;

        public UpdateSeoSettingCommandHandler(IRepository<SeoSetting> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSeoSettingCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.SeoSettingID);
            if (value != null)
            {
                value.PageName = request.PageName;
                value.MetaTitle_TR = request.MetaTitle_TR;
                value.MetaDescription_TR = request.MetaDescription_TR;
                value.MetaTitle_EN = request.MetaTitle_EN;
                value.MetaDescription_EN = request.MetaDescription_EN;

                await _repository.UpdateAsync(value);
            }
        }
    }
}