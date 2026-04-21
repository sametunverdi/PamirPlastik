using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ProductImageQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetProductImagesByProductId/{id}")]
        public async Task<IActionResult> GetProductImagesByProductId(int id)
        {
            var values = await _mediator.Send(new GetProductImageByProductIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün Görseli Başarıyla Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProductImage(int id)
        {
            await _mediator.Send(new RemoveProductImageCommand(id));
            return Ok("Ürün Görseli Başarıyla Silindi");
        }
    }
}