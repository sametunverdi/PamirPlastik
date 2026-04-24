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
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand>
    {
        private readonly IRepository<About> _repository;

        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new About
            {
                SeoTitle_TR = request.SeoTitle_TR,
                SeoTitle_EN = request.SeoTitle_EN,
                SeoDescription_TR = request.SeoDescription_TR,
                SeoDescription_EN = request.SeoDescription_EN,
                MainTitle_TR = request.MainTitle_TR,
                MainTitle_EN = request.MainTitle_EN,
                SubTitle_TR = request.SubTitle_TR,
                SubTitle_EN = request.SubTitle_EN,
                Description1_TR = request.Description1_TR,
                Description1_EN = request.Description1_EN,
                Description2_TR = request.Description2_TR,
                Description2_EN = request.Description2_EN,
                HighlightQuote_TR = request.HighlightQuote_TR,
                HighlightQuote_EN = request.HighlightQuote_EN,
                VisionTitle_TR = request.VisionTitle_TR,
                VisionTitle_EN = request.VisionTitle_EN,
                VisionDescription_TR = request.VisionDescription_TR,
                VisionDescription_EN = request.VisionDescription_EN,
                MissionTitle_TR = request.MissionTitle_TR,
                MissionTitle_EN = request.MissionTitle_EN,
                MissionDescription_TR = request.MissionDescription_TR,
                MissionDescription_EN = request.MissionDescription_EN
            });
        }
    }
}
