using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.SiteSettingCommands;
using PamirPlastik.Application.Features.Mediator.Queries.SiteSettingQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteSettingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SiteSettingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> SiteSettingList()
        {
            var values = await _mediator.Send(new GetSiteSettingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSiteSetting(int id)
        {
            var value = await _mediator.Send(new GetSiteSettingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSiteSetting(CreateSiteSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Site Ayarları Başarıyla Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveSiteSetting(int id)
        {
            await _mediator.Send(new RemoveSiteSettingCommand(id));
            return Ok("Site Ayarları Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSiteSetting(UpdateSiteSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Site Ayarları Başarıyla Güncellendi");
        }
    }
}