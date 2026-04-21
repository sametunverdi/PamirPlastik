using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.AboutCommands;
using PamirPlastik.Application.Features.Mediator.Queries.AboutPageQueries;
using PamirPlastik.Application.Features.Mediator.Queries.AboutQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _mediator.Send(new GetAboutQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var values = await _mediator.Send(new GetAboutByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımızda Bilgisi Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımızda Bilgisi Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _mediator.Send(new RemoveAboutCommand(id));
            return Ok("Hakkımızda Bilgisi Başarıyla Silindi");
        }
        [HttpGet("GetAboutPage")]
        public async Task<IActionResult> GetAboutPage(string lang = "tr")
        {
            var values = await _mediator.Send(new GetAboutPageQuery(lang));
            if (values == null)
            {
                return NotFound("Hakkımızda sayfası bulunamadı.");
            }
            return Ok(values);
        }
    }
}