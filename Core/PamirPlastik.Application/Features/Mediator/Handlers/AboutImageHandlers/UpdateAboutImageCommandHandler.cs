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
    public class UpdateAboutImageCommandHandler : IRequestHandler<UpdateAboutImageCommand>
    {
        private readonly IRepository<AboutImage> _repository;
        public UpdateAboutImageCommandHandler(IRepository<AboutImage> repository) { _repository = repository; }

        public async Task Handle(UpdateAboutImageCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            if (values != null)
            {
                values.AboutId = request.AboutId;
                values.ImageUrl = request.ImageUrl;
                values.AltText_TR = request.AltText_TR;
                values.AltText_EN = request.AltText_EN;
                values.Order = request.Order;

                await _repository.UpdateAsync(values);
            }
        }
    }
}
