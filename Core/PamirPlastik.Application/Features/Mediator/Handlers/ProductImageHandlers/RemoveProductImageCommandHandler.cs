using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductImageHandlers
{
    public class RemoveProductImageCommandHandler : IRequestHandler<RemoveProductImageCommand>
    {
        private readonly IRepository<ProductImage> _repository;

        public RemoveProductImageCommandHandler(IRepository<ProductImage> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveProductImageCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            if (value != null)
            {
                await _repository.RemoveAsync(value);
            }
        }
    }
}