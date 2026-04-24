using MediatR;
using PamirPlastik.Application.Features.Mediator.Commands.ContactCommands;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand>
    {
        private readonly IRepository<Contact> _repository;
        public CreateContactCommandHandler(IRepository<Contact> repository) => _repository = repository;

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Contact
            {
                Title_TR = request.Title_TR,
                Title_EN = request.Title_EN,
                Description_TR = request.Description_TR,
                Description_EN = request.Description_EN,
                PhoneTitle_TR = request.PhoneTitle_TR,
                PhoneTitle_EN = request.PhoneTitle_EN,
                Phone = request.Phone,
                PhoneDescription_TR = request.PhoneDescription_TR,
                PhoneDescription_EN = request.PhoneDescription_EN,
                EmailTitle_TR = request.EmailTitle_TR,
                EmailTitle_EN = request.EmailTitle_EN,
                Email = request.Email,
                EmailDescription_TR = request.EmailDescription_TR,
                EmailDescription_EN = request.EmailDescription_EN,
                MapLocation = request.MapLocation,
                MapTitle_TR = request.MapTitle_TR,
                MapTitle_EN = request.MapTitle_EN,
                Address_TR = request.Address_TR,
                Address_EN = request.Address_EN
            });
        }
    }
}
