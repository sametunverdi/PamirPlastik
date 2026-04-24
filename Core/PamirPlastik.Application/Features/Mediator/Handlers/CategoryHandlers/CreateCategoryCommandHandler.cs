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
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
    {
        private readonly IRepository<Category> _repository;
        public CreateCategoryCommandHandler(IRepository<Category> repository) { _repository = repository; }

        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Category
            {
                Name_TR = request.Name_TR,
                Name_EN = request.Name_EN,
                Description_TR = request.Description_TR,
                Description_EN = request.Description_EN,
                ImageUrl = request.ImageUrl,
                Slug = request.Slug,
                Status = request.Status
            });
        }
    }
}
