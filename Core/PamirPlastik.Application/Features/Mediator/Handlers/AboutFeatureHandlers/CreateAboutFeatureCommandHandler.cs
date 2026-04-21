using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.AboutFeatureCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.AboutFeatureHandlers
{
    public class CreateAboutFeatureCommandHandler : IRequestHandler<CreateAboutFeatureCommand>
    {
        private readonly IRepository<AboutFeature> _repository;
        public CreateAboutFeatureCommandHandler(IRepository<AboutFeature> repository) { _repository = repository; }

        public async Task Handle(CreateAboutFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AboutFeature
            {
                Order = request.Order,
                Title_TR = request.Title_TR,
                Title_EN = request.Title_EN,
                Description_TR = request.Description_TR,
                Description_EN = request.Description_EN,
                IsActive = request.IsActive,

                // KRİTİK EKLEME:
                AboutID = request.AboutID
            });
        }
    }
}