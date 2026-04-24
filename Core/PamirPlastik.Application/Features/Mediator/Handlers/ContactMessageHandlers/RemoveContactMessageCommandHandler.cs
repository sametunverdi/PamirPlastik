using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ContactMessageCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ContactMessageHandlers
{
    public class RemoveContactMessageCommandHandler : IRequestHandler<RemoveContactMessageCommand>
    {
        private readonly IRepository<ContactMessage> _repository;
        public RemoveContactMessageCommandHandler(IRepository<ContactMessage> repository) => _repository = repository;

        public async Task Handle(RemoveContactMessageCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
