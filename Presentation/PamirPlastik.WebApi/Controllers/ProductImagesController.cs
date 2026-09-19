using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ProductImageCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ProductImageQueries;

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

        [HttpGet]
        public async Task<IActionResult> ProductImageList()
        {
            var values = await _mediator.Send(new GetProductImageQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImage(int id)
        {
            var value = await _mediator.Send(new GetProductImageByIdQuery(id));
            return Ok(value);
        }

        [HttpGet("ByProductId/{id}")]
        public async Task<IActionResult> GetProductImagesByProductId(int id)
        {
            var values = await _mediator.Send(new GetProductImagesByProductIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün resmi başarıyla eklendi kanka!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProductImage(int id)
        {
            await _mediator.Send(new RemoveProductImageCommand(id));
            return Ok("Ürün resmi başarıyla silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün resmi başarıyla güncellendi!");
        }
    }
}
