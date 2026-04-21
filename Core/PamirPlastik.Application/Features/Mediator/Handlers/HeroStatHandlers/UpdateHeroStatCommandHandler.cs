using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.HeroStatCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.HeroStatHandlers
{
    public class UpdateHeroStatCommandHandler : IRequestHandler<UpdateHeroStatCommand>
    {
        private readonly IRepository<HeroStat> _repository;
        public UpdateHeroStatCommandHandler(IRepository<HeroStat> repository) { _repository = repository; }

        public async Task Handle(UpdateHeroStatCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.HeroStatID);
            if (values != null)
            {
                values.Value = request.Value;
                values.Label_TR = request.Label_TR;
                values.Label_EN = request.Label_EN;
                values.IsActive = request.IsActive;
                await _repository.UpdateAsync(values);
            }
        }
    }
}