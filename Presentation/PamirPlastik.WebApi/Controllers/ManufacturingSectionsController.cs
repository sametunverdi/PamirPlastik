using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ManufacturingSectionCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ManufacturingSectionQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturingSectionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ManufacturingSectionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ManufacturingSectionList()
        {
            var values = await _mediator.Send(new GetManufacturingSectionQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetManufacturingSection(int id)
        {
            var values = await _mediator.Send(new GetManufacturingSectionByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateManufacturingSection(CreateManufacturingSectionCommand command)
        {
            await _mediator.Send(command);
            return Ok("Üretim Vizyon Bölümü Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateManufacturingSection(UpdateManufacturingSectionCommand command)
        {
            await _mediator.Send(command);
            return Ok("Üretim Vizyon Bölümü Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveManufacturingSection(int id)
        {
            await _mediator.Send(new RemoveManufacturingSectionCommand(id));
            return Ok("Üretim Vizyon Bölümü Başarıyla Silindi");
        }
    }
}