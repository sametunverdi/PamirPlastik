using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.AboutImageCommands;
using PamirPlastik.Application.Features.Mediator.Queries.AboutImageQueries;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutImagesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AboutImagesController(IMediator mediator) { _mediator = mediator; }

        [HttpGet]
        public async Task<IActionResult> AboutImageList()
        {
            var values = await _mediator.Send(new GetAboutImageQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutImage(CreateAboutImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Resim eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAboutImage(int id)
        {
            await _mediator.Send(new RemoveAboutImageCommand(id));
            return Ok("Resim silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAboutImage(UpdateAboutImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Resim güncellendi");
        }
    }
}
