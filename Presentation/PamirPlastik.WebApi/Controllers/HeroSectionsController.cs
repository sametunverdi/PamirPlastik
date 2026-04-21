using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.HeroSectionCommands;
using PamirPlastik.Application.Features.Mediator.Queries.HeroSectionQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroSectionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HeroSectionsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> HeroSectionList()
        {
            var values = await _mediator.Send(new GetHeroSectionQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHeroSection(int id)
        {
            var values = await _mediator.Send(new GetHeroSectionByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHeroSection(CreateHeroSectionCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ana Sayfa Vitrin Bilgisi Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHeroSection(UpdateHeroSectionCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ana Sayfa Vitrin Bilgisi Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveHeroSection(int id)
        {
            await _mediator.Send(new RemoveHeroSectionCommand(id));
            return Ok("Ana Sayfa Vitrin Bilgisi Başarıyla Silindi");
        }
    }
}