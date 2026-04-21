using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.CategoryCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.CategoryID);
            if (value != null)
            {
                value.Name_TR = request.Name_TR;
                value.Description_TR = request.Description_TR;
                value.Name_EN = request.Name_EN;
                value.Description_EN = request.Description_EN;
                value.ImagePath = request.ImagePath;
                value.ImageAlt_TR = request.ImageAlt_TR;
                value.ImageAlt_EN = request.ImageAlt_EN;
                value.Slug = request.Slug;
                value.Order = request.Order;
                value.IsActive = request.IsActive;
                value.MetaTitle_TR = request.MetaTitle_TR;
                value.MetaTitle_EN = request.MetaTitle_EN;
                value.MetaDescription_TR = request.MetaDescription_TR;
                value.MetaDescription_EN = request.MetaDescription_EN;

                await _repository.UpdateAsync(value);
            }
        }
    }
}