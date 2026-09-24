using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.DeveloperSettingCommands;
using PamirPlastik.Application.Features.Mediator.Queries.DeveloperSettingQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperSettingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DeveloperSettingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> DeveloperSettingList()
        {
            var values = await _mediator.Send(new GetDeveloperSettingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeveloperSetting(int id)
        {
            var value = await _mediator.Send(new GetDeveloperSettingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeveloperSetting(CreateDeveloperSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveDeveloperSetting(int id)
        {
            await _mediator.Send(new RemoveDeveloperSettingCommand(id));
            return Ok("Başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDeveloperSetting(UpdateDeveloperSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarıyla güncellendi");
        }
    }
}
