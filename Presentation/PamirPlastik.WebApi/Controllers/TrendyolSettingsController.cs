using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.TrendyolSettingCommands;
using PamirPlastik.Application.Features.Mediator.Queries.TrendyolSettingQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendyolSettingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TrendyolSettingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TrendyolSettingList()
        {
            
            var values = await _mediator.Send(new GetTrendyolSettingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrendyolSetting(int id)
        {
            var value = await _mediator.Send(new GetTrendyolSettingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrendyolSetting(CreateTrendyolSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Trendyol Ayarları Başarıyla Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveTrendyolSetting(int id)
        {
            await _mediator.Send(new RemoveTrendyolSettingCommand(id));
            return Ok("Trendyol Ayarları Başarıyla Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTrendyolSetting(UpdateTrendyolSettingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Trendyol Ayarları Başarıyla Güncellendi");
        }
    }
}