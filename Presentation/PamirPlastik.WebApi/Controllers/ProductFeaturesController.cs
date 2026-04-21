using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ProductFeatureCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ProductFeatureQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetProductFeaturesByProductId/{id}")]
        public async Task<IActionResult> GetProductFeaturesByProductId(int id)
        {
            var values = await _mediator.Send(new GetProductFeatureByProductIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductFeature(CreateProductFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün Teknik Özelliği Başarıyla Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProductFeature(int id)
        {
            await _mediator.Send(new RemoveProductFeatureCommand(id));
            return Ok("Ürün Teknik Özelliği Başarıyla Silindi");
        }
    }
}