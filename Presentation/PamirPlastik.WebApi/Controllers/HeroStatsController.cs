using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.HeroStatCommands;
using PamirPlastik.Application.Features.Mediator.Queries.HeroStatQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroStatsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HeroStatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> HeroStatList()
        {
            var values = await _mediator.Send(new GetHeroStatQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHeroStat(int id)
        {
            var values = await _mediator.Send(new GetHeroStatByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHeroStat(CreateHeroStatCommand command)
        {
            await _mediator.Send(command);
            return Ok("İstatistik Bilgisi Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHeroStat(UpdateHeroStatCommand command)
        {
            await _mediator.Send(command);
            return Ok("İstatistik Bilgisi Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveHeroStat(int id)
        {
            await _mediator.Send(new RemoveHeroStatCommand(id));
            return Ok("İstatistik Bilgisi Başarıyla Silindi");
        }
    }
}