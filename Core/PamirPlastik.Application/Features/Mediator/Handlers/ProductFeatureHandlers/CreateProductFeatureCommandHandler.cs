using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductFeatureCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductFeatureHandlers
{
    public class CreateProductFeatureCommandHandler : IRequestHandler<CreateProductFeatureCommand>
    {
        private readonly IRepository<ProductFeature> _repository;

        public CreateProductFeatureCommandHandler(IRepository<ProductFeature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ProductFeature
            {
                Feature_TR = request.Feature_TR,
                Feature_EN = request.Feature_EN,
                ProductID = request.ProductID
            });
        }
    }
}