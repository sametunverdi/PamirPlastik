using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.HeroBadgeCommands;
using PamirPlastik.Application.Features.Mediator.Queries.HeroBadgeQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroBadgesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HeroBadgesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> HeroBadgeList()
        {
            var values = await _mediator.Send(new GetHeroBadgeQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHeroBadge(int id)
        {
            var values = await _mediator.Send(new GetHeroBadgeByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHeroBadge(CreateHeroBadgeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kahraman Rozeti Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHeroBadge(UpdateHeroBadgeCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kahraman Rozeti Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveHeroBadge(int id)
        {
            await _mediator.Send(new RemoveHeroBadgeCommand(id));
            return Ok("Kahraman Rozeti Başarıyla Silindi");
        }
    }
}