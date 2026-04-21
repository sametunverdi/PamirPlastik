using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.FairCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.FairHandlers
{
    public class UpdateFairCommandHandler : IRequestHandler<UpdateFairCommand>
    {
        private readonly IRepository<Fair> _repository;
        public UpdateFairCommandHandler(IRepository<Fair> repository) { _repository = repository; }

        public async Task Handle(UpdateFairCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FairID);
            if (values != null)
            {
                values.Name_TR = request.Name_TR;
                values.Description_TR = request.Description_TR;
                values.ImageAlt_TR = request.ImageAlt_TR;
                values.Name_EN = request.Name_EN;
                values.Description_EN = request.Description_EN;
                values.ImageAlt_EN = request.ImageAlt_EN;
                values.Location = request.Location;
                values.StandNo = request.StandNo;
                values.FairDate = request.FairDate;
                values.ImagePath1 = request.ImagePath1;
                values.ImagePath2 = request.ImagePath2;
                values.IsActive = request.IsActive;
                await _repository.UpdateAsync(values);
            }
        }
    }
}