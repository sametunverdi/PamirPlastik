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
    public class GetContactMessageQueryHandler : IRequestHandler<GetContactMessageQuery, List<GetContactMessageQueryResult>>
    {
        private readonly IRepository<ContactMessage> _repository;
        public GetContactMessageQueryHandler(IRepository<ContactMessage> repository) => _repository = repository;

        public async Task<List<GetContactMessageQueryResult>> Handle(GetContactMessageQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactMessageQueryResult
            {
                ContactMessageID = x.ContactMessageID,
                FullName = x.FullName,
                Email = x.Email,
                Company = x.Company,
                Subject = x.Subject,
                MessageDetail = x.MessageDetail,
                SendDate = x.SendDate,
                IsRead = x.IsRead
            }).OrderByDescending(x => x.SendDate).ToList(); // En yeni mesaj en üstte gelsin
        }
    }
}
