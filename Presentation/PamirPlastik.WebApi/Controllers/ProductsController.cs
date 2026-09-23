using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.ProductCommands;
using PamirPlastik.Application.Features.Mediator.Queries.ProductQueries;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _mediator.Send(new GetProductQuery());
            return Ok(values);
        }

        [HttpGet("GetBySlug/{slug}")]
        public async Task<IActionResult> GetProductBySlug(string slug)
        {
            var value = await _mediator.Send(new GetProductBySlugQuery(slug));
            if (value == null) return NotFound();
            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var value = await _mediator.Send(new GetProductByIdQuery(id));
            return Ok(value);
        }

        // Ana sayfadaki vitrin (Yýldýzlý) ürünleri getirecek özel endpoint
        [HttpGet("GetFeaturedProducts")]
        public async Task<IActionResult> GetFeaturedProducts()
        {
            var values = await _mediator.Send(new GetFeaturedProductQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return Ok("Ürün baþarýyla silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün baþarýyla güncellendi!");
        }
        [HttpGet("GetProductsByCategory")]
        public async Task<IActionResult> GetProductsByCategory(int id)
        {
            var values = await _mediator.Send(new GetProductByCategoryQuery(id));
            return Ok(values);
        }
        [HttpGet("GetProductPagination")]
        public async Task<IActionResult> GetProductPagination(int page = 1, int pageSize = 9, int? categoryID = null, string? searchQuery = null)
        {
            var values = await _mediator.Send(new GetProductPaginationQuery(page, pageSize, categoryID, searchQuery));
            return Ok(values);
        }
    }
}
