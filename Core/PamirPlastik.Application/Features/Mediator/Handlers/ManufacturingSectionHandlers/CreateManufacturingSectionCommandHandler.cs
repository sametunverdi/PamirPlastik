using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ManufacturingSectionCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ManufacturingSectionHandlers
{
    public class CreateManufacturingSectionCommandHandler : IRequestHandler<CreateManufacturingSectionCommand>
    {
        private readonly IRepository<ManufacturingSection> _repository;
        public CreateManufacturingSectionCommandHandler(IRepository<ManufacturingSection> repository) { _repository = repository; }

        public async Task Handle(CreateManufacturingSectionCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ManufacturingSection
            {
                SubTitle_TR = request.SubTitle_TR,
                TitleMain_TR = request.TitleMain_TR,
                TitleHighlight_TR = request.TitleHighlight_TR,
                Description_TR = request.Description_TR,
                ButtonText_TR = request.ButtonText_TR,
                SubTitle_EN = request.SubTitle_EN,
                TitleMain_EN = request.TitleMain_EN,
                TitleHighlight_EN = request.TitleHighlight_EN,
                Description_EN = request.Description_EN,
                ButtonText_EN = request.ButtonText_EN,
                ButtonUrl = request.ButtonUrl,
                ImagePath = request.ImagePath,
                ImageAlt_TR = request.ImageAlt_TR,
                ImageAlt_EN = request.ImageAlt_EN,
                StatValue = request.StatValue,
                StatLabel_TR = request.StatLabel_TR,
                StatLabel_EN = request.StatLabel_EN,
                IsActive = request.IsActive
            });
        }
    }
}