using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.SeoSettingCommands;
using PamirPlastik.Application.Features.Mediator.Queries.SeoSettingQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeoSettingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SeoSettingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> SeoSettingList()
        {
            var values = await _mediator.Send(new GetSeoSettingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSeoSetting(int id)
        {
            var value = await _mediator.Send(new GetSeoSettingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSeoSetting(CreateSeoSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("SEO Ayarları Başarıyla Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveSeoSetting(int id)
        {
            await _mediator.Send(new RemoveSeoSettingCommand(id));
            return Ok("SEO Ayarları Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSeoSetting(UpdateSeoSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("SEO Ayarları Başarıyla Güncellendi");
        }
    }
}