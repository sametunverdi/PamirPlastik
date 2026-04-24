using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            if (values != null)
            {
                values.SeoTitle_TR = request.SeoTitle_TR;
                values.SeoTitle_EN = request.SeoTitle_EN;
                values.SeoDescription_TR = request.SeoDescription_TR;
                values.SeoDescription_EN = request.SeoDescription_EN;
                values.MainTitle_TR = request.MainTitle_TR;
                values.MainTitle_EN = request.MainTitle_EN;
                values.SubTitle_TR = request.SubTitle_TR;
                values.SubTitle_EN = request.SubTitle_EN;
                values.Description1_TR = request.Description1_TR;
                values.Description1_EN = request.Description1_EN;
                values.Description2_TR = request.Description2_TR;
                values.Description2_EN = request.Description2_EN;
                values.HighlightQuote_TR = request.HighlightQuote_TR;
                values.HighlightQuote_EN = request.HighlightQuote_EN;
                values.VisionTitle_TR = request.VisionTitle_TR;
                values.VisionTitle_EN = request.VisionTitle_EN;
                values.VisionDescription_TR = request.VisionDescription_TR;
                values.VisionDescription_EN = request.VisionDescription_EN;
                values.MissionTitle_TR = request.MissionTitle_TR;
                values.MissionTitle_EN = request.MissionTitle_EN;
                values.MissionDescription_TR = request.MissionDescription_TR;
                values.MissionDescription_EN = request.MissionDescription_EN;

                await _repository.UpdateAsync(values);
            }
        }
    }
}
