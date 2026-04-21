using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.CategoryCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly IRepository<Category> _repository;

        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Category
            {
                Name_TR = request.Name_TR,
                Description_TR = request.Description_TR,
                Name_EN = request.Name_EN,
                Description_EN = request.Description_EN,
                ImagePath = request.ImagePath,
                ImageAlt_TR = request.ImageAlt_TR,
                ImageAlt_EN = request.ImageAlt_EN,
                Slug = request.Slug,
                Order = request.Order,
                IsActive = request.IsActive,
                MetaTitle_TR = request.MetaTitle_TR,
                MetaTitle_EN = request.MetaTitle_EN,
                MetaDescription_TR = request.MetaDescription_TR,
                MetaDescription_EN = request.MetaDescription_EN
            });
        }
    }
}