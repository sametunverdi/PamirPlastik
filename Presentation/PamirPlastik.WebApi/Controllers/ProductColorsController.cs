using MediatR;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductColors(int productId)
        {
            var values = await _mediator.Send(new GetColorsByProductIdQuery(productId));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> AssignColorsToProduct(AssignColorsToProductCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ürün Renkleri başarıyla atandı");
        }
    }
}