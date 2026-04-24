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
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand>
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ContactID);

            value.Title_TR = request.Title_TR;
            value.Title_EN = request.Title_EN;
            value.Description_TR = request.Description_TR;
            value.Description_EN = request.Description_EN;
            value.PhoneTitle_TR = request.PhoneTitle_TR;
            value.PhoneTitle_EN = request.PhoneTitle_EN;
            value.Phone = request.Phone;
            value.PhoneDescription_TR = request.PhoneDescription_TR;
            value.PhoneDescription_EN = request.PhoneDescription_EN;
            value.EmailTitle_TR = request.EmailTitle_TR;
            value.EmailTitle_EN = request.EmailTitle_EN;
            value.Email = request.Email;
            value.EmailDescription_TR = request.EmailDescription_TR;
            value.EmailDescription_EN = request.EmailDescription_EN;
            value.MapLocation = request.MapLocation;
            value.MapTitle_TR = request.MapTitle_TR;
            value.MapTitle_EN = request.MapTitle_EN;
            value.Address_TR = request.Address_TR;
            value.Address_EN = request.Address_EN;

            await _repository.UpdateAsync(value);
        }
    }
}
