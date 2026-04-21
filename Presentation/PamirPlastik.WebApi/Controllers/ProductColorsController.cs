using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ProductColorCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ProductColorQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductColorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductColorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

     
        [HttpGet("GetProductColorsByProductId/{id}")]
        public async Task<IActionResult> GetProductColorsByProductId(int id)
        {
            var values = await _mediator.Send(new GetProductColorByProductIdQuery(id));
            return Ok(values);
        }

 
        [HttpPost]
        public async Task<IActionResult> CreateProductColor(CreateProductColorCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün Rengi Başarıyla Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProductColor(int id)
        {
            await _mediator.Send(new RemoveProductColorCommand(id));
            return Ok("Ürün Rengi Başarıyla Silindi");
        }
    }
}