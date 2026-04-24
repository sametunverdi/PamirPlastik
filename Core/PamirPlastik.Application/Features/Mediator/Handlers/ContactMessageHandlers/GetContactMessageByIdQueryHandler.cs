using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ContactMessageQueries;
using PamirPlastik.Application.Features.Mediator.Results.ContactMessageResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ContactMessageHandlers
{
    public class GetContactMessageByIdQueryHandler : IRequestHandler<GetContactMessageByIdQuery, GetContactMessageByIdQueryResult>
    {
        private readonly IRepository<ContactMessage> _repository;
        public GetContactMessageByIdQueryHandler(IRepository<ContactMessage> repository) => _repository = repository;

        public async Task<GetContactMessageByIdQueryResult> Handle(GetContactMessageByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetContactMessageByIdQueryResult
            {
                ContactMessageID = value.ContactMessageID,
                FullName = value.FullName,
                Email = value.Email,
                Company = value.Company,
                Subject = value.Subject,
                MessageDetail = value.MessageDetail,
                SendDate = value.SendDate,
                IsRead = value.IsRead
            };
        }
    }
}
