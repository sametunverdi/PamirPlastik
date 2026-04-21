using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.FairCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.FairHandlers
{
    public class CreateFairCommandHandler : IRequestHandler<CreateFairCommand>
    {
        private readonly IRepository<Fair> _repository;
        public CreateFairCommandHandler(IRepository<Fair> repository) { _repository = repository; }

        public async Task Handle(CreateFairCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Fair
            {
                Name_TR = request.Name_TR,
                Description_TR = request.Description_TR,
                ImageAlt_TR = request.ImageAlt_TR,
                Name_EN = request.Name_EN,
                Description_EN = request.Description_EN,
                ImageAlt_EN = request.ImageAlt_EN,
                Location = request.Location,
                StandNo = request.StandNo,
                FairDate = request.FairDate,
                ImagePath1 = request.ImagePath1,
                ImagePath2 = request.ImagePath2,
                IsActive = request.IsActive
            });
        }
    }
}