using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ContactMessageCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ContactMessageQueries;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactMessagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactMessagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ContactMessageList()
        {
            var values = await _mediator.Send(new GetContactMessageQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactMessageById(int id)
        {
            var value = await _mediator.Send(new GetContactMessageByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContactMessage(CreateContactMessageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Mesaj başarıyla gönderildi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveContactMessage(int id)
        {
            await _mediator.Send(new RemoveContactMessageCommand(id));
            return Ok("Mesaj başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContactMessage(UpdateContactMessageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Mesaj durumu başarıyla güncellendi.");
        }
    }
}
