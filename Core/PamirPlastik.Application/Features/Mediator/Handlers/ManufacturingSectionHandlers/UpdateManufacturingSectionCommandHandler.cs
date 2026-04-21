using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ManufacturingSectionCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingSectionHandlers
{
    public class UpdateManufacturingSectionCommandHandler : IRequestHandler<UpdateManufacturingSectionCommand>
    {
        private readonly IRepository<ManufacturingSection> _repository;
        public UpdateManufacturingSectionCommandHandler(IRepository<ManufacturingSection> repository) { _repository = repository; }

        public async Task Handle(UpdateManufacturingSectionCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ManufacturingSectionID);
            if (values != null)
            {
                values.SubTitle_TR = request.SubTitle_TR;
                values.TitleMain_TR = request.TitleMain_TR;
                values.TitleHighlight_TR = request.TitleHighlight_TR;
                values.Description_TR = request.Description_TR;
                values.ButtonText_TR = request.ButtonText_TR;
                values.SubTitle_EN = request.SubTitle_EN;
                values.TitleMain_EN = request.TitleMain_EN;
                values.TitleHighlight_EN = request.TitleHighlight_EN;
                values.Description_EN = request.Description_EN;
                values.ButtonText_EN = request.ButtonText_EN;
                values.ButtonUrl = request.ButtonUrl;
                values.ImagePath = request.ImagePath;
                values.ImageAlt_TR = request.ImageAlt_TR;
                values.ImageAlt_EN = request.ImageAlt_EN;
                values.StatValue = request.StatValue;
                values.StatLabel_TR = request.StatLabel_TR;
                values.StatLabel_EN = request.StatLabel_EN;
                values.IsActive = request.IsActive;

                await _repository.UpdateAsync(values);
            }
        }
    }
}