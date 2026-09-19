using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ProductColorCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Linq;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ProductColorHandlers
{
    public class AssignColorsToProductCommandHandler : IRequestHandler<AssignColorsToProductCommand>
    {
        private readonly IRepository<ProductColor> _repository;

        public AssignColorsToProductCommandHandler(IRepository<ProductColor> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AssignColorsToProductCommand request, CancellationToken cancellationToken)
        {
            // İlk olarak ürüne ait eski renkleri bul ve sil
            var existingColors = (await _repository.GetAllAsync()).Where(x => x.ProductID == request.ProductID).ToList();
            foreach (var existingColor in existingColors)
            {
                await _repository.RemoveAsync(existingColor);
            }

            // Eğer yeni renkler geldiyse, onları ekle
            if (request.ColorIDs != null && request.ColorIDs.Any())
            {
                foreach (var colorId in request.ColorIDs)
                {
                    await _repository.CreateAsync(new ProductColor
                    {
                        ProductID = request.ProductID,
                        ColorID = colorId
                    });
                }
            }
        }
    }
}