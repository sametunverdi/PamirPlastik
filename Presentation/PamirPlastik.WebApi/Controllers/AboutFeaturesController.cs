using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.AboutFeatureCommands;
using PamirPlastik.Application.Features.Mediator.Queries.AboutFeatureQueries;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AboutFeaturesController(IMediator mediator) { _mediator = mediator; }

        [HttpGet]
        public async Task<IActionResult> AboutFeatureList()
        {
            var values = await _mediator.Send(new GetAboutFeatureQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutFeature(CreateAboutFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAboutFeature(int id)
        {
            await _mediator.Send(new RemoveAboutFeatureCommand(id));
            return Ok("Özellik silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAboutFeature(UpdateAboutFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik güncellendi");
        }
    }
}
