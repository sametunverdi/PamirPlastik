using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ManufacturingFeatureCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ManufacturingFeatureQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturingFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ManufacturingFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ManufacturingFeatureList()
        {
            var values = await _mediator.Send(new GetManufacturingFeatureQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetManufacturingFeature(int id)
        {
            var values = await _mediator.Send(new GetManufacturingFeatureByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateManufacturingFeature(CreateManufacturingFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Üretim Özelliği Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateManufacturingFeature(UpdateManufacturingFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Üretim Özelliği Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveManufacturingFeature(int id)
        {
            await _mediator.Send(new RemoveManufacturingFeatureCommand(id));
            return Ok("Üretim Özelliği Başarıyla Silindi");
        }
    }
}