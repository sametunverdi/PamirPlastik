using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.CategoryCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly IRepository<Category> _repository;
        public UpdateCategoryCommandHandler(IRepository<Category> repository) { _repository = repository; }

        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.CategoryID);
            value.Name_TR = request.Name_TR;
            value.Name_EN = request.Name_EN;
            value.Description_TR = request.Description_TR;
            value.Description_EN = request.Description_EN;
            value.ImageUrl = request.ImageUrl;
            value.Slug = request.Slug;
            value.Status = request.Status;
            await _repository.UpdateAsync(value);
        }
    }
}
