using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductColorCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductColorHandlers
{
    public class CreateProductColorCommandHandler : IRequestHandler<CreateProductColorCommand>
    {
        private readonly IRepository<ProductColor> _repository;

        public CreateProductColorCommandHandler(IRepository<ProductColor> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductColorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ProductColor
            {
                ColorName_TR = request.ColorName_TR,
                ColorName_EN = request.ColorName_EN,
                ColorHex = request.ColorHex,
                ProductID = request.ProductID
            });
        }
    }
}