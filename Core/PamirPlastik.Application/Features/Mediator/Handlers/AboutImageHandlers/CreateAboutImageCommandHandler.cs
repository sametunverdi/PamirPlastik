using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutImageHandlers
{
    public class CreateAboutImageCommandHandler : IRequestHandler<CreateAboutImageCommand>
    {
        private readonly IRepository<AboutImage> _repository;
        public CreateAboutImageCommandHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task Handle(CreateAboutImageCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AboutImage
            {
                AboutId = request.AboutId,
                ImageUrl = request.ImageUrl,
                AltText_TR = request.AltText_TR,
                AltText_EN = request.AltText_EN,
                Order = request.Order
            });
        }
    }
}
