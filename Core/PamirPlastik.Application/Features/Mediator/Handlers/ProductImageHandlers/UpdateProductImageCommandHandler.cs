using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductImageHandlers
{
    public class UpdateProductImageCommandHandler : IRequestHandler<UpdateProductImageCommand>
    {
        private readonly IRepository<ProductImage> _repository;

        public UpdateProductImageCommandHandler(IRepository<ProductImage> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductImageCommand request, CancellationToken cancellationToken)
        {
            // Sen Command sınıfında bu ID'nin adını ProductImageID yapmıştın, aynen kullanıyoruz.
            var value = await _repository.GetByIdAsync(request.ProductImageID);
            if (value != null)
            {
                value.ImageUrl = request.ImageUrl;
                value.ProductID = request.ProductID;

                await _repository.UpdateAsync(value);
            }
        }
    }
}
