using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.HomePageSettingCommands;
using PamirPlastik.Application.Features.Mediator.Queries.HomePageSettingQueries;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageSettingsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HomePageSettingsController(IMediator mediator) { _mediator = mediator; }

        [HttpGet]
        public async Task<IActionResult> HomePageSettingList()
        {
            var values = await _mediator.Send(new GetHomePageSettingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHomePageSetting(int id)
        {
            var value = await _mediator.Send(new GetHomePageSettingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHomePageSetting(CreateHomePageSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ana sayfa ayarı başarıyla eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveHomePageSetting(int id)
        {
            await _mediator.Send(new RemoveHomePageSettingCommand(id));
            return Ok("Ana sayfa ayarı başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHomePageSetting(UpdateHomePageSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ana sayfa ayarı başarıyla güncellendi");
        }
    }
}
