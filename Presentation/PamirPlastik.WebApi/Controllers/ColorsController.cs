using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ColorCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ColorQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ColorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ColorList()
        {
            var values = await _mediator.Send(new GetColorQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetColor(int id)
        {
            var value = await _mediator.Send(new GetColorByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateColor(CreateColorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Renk başarıyla eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveColor(int id)
        {
            await _mediator.Send(new RemoveColorCommand(id));
            return Ok("Renk başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateColor(UpdateColorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Renk başarıyla güncellendi");
        }
    }
}