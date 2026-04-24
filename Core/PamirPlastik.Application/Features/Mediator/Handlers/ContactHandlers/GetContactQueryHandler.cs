using MediatR;
using PamirPlastik.Application.Features.Mediator.Queries.ContactQueries;
using PamirPlastik.Application.Features.Mediator.Results.ContactResults;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class GetContactQueryHandler : IRequestHandler<GetContactQuery, List<GetContactQueryResult>>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactQueryResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactQueryResult
            {
                ContactID = x.ContactID,
                Title_TR = x.Title_TR,
                Title_EN = x.Title_EN,
                Description_TR = x.Description_TR,
                Description_EN = x.Description_EN,
                PhoneTitle_TR = x.PhoneTitle_TR,
                PhoneTitle_EN = x.PhoneTitle_EN,
                Phone = x.Phone,
                PhoneDescription_TR = x.PhoneDescription_TR,
                PhoneDescription_EN = x.PhoneDescription_EN,
                EmailTitle_TR = x.EmailTitle_TR,
                EmailTitle_EN = x.EmailTitle_EN,
                Email = x.Email,
                EmailDescription_TR = x.EmailDescription_TR,
                EmailDescription_EN = x.EmailDescription_EN,
                MapLocation = x.MapLocation,
                MapTitle_TR = x.MapTitle_TR,
                MapTitle_EN = x.MapTitle_EN,
                Address_TR = x.Address_TR,
                Address_EN = x.Address_EN
            }).ToList();
        }
    }
}
