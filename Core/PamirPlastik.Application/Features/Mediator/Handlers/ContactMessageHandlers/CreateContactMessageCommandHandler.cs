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
    public class CreateContactMessageCommandHandler : IRequestHandler<CreateContactMessageCommand>
    {
        private readonly IRepository<ContactMessage> _repository;
        public CreateContactMessageCommandHandler(IRepository<ContactMessage> repository) => _repository = repository;

        public async Task Handle(CreateContactMessageCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ContactMessage
            {
                FullName = request.FullName,
                Email = request.Email,
                Company = request.Company,
                Subject = request.Subject,
                MessageDetail = request.MessageDetail,
                SendDate = request.SendDate,
                IsRead = false // Yeni gelen mesaj her zaman okunmadı olarak başlar
            });
        }
    }
}
