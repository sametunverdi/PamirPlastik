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
    public class UpdateContactMessageCommandHandler : IRequestHandler<UpdateContactMessageCommand>
    {
        private readonly IRepository<ContactMessage> _repository;
        public UpdateContactMessageCommandHandler(IRepository<ContactMessage> repository) => _repository = repository;

        public async Task Handle(UpdateContactMessageCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ContactMessageID);

            value.FullName = request.FullName;
            value.Email = request.Email;
            value.Company = request.Company;
            value.Subject = request.Subject;
            value.MessageDetail = request.MessageDetail;
            value.SendDate = request.SendDate;
            value.IsRead = request.IsRead;

            await _repository.UpdateAsync(value);
        }
    }
}
