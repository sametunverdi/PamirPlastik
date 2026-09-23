using MediatR; 
using Microsoft.AspNetCore.Mvc; 
using PamirPlastik.Application.Features.Mediator.Commands.FairCommands;
using PamirPlastik.Application.Features.Mediator.Queries.FairQueries; 
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers 
{ 
    [Route("api/[controller]")] 
    [ApiController] 
    public class FairsController : ControllerBase 
    { 
        private readonly IMediator _mediator; 
        
        public FairsController(IMediator mediator) 
        { 
            _mediator = mediator; 
        } 
        
        [HttpGet] 
        public async Task<IActionResult> FairList() 
        { 
            var values = await _mediator.Send(new GetFairQuery()); 
            return Ok(values); 
        } 
        
        [HttpGet("{id}")] 
        public async Task<IActionResult> GetFair(int id) 
        { 
            var value = await _mediator.Send(new GetFairByIdQuery(id)); 
            return Ok(value); 
        }

        [HttpPost]
        public async Task<IActionResult> CreateFair(CreateFairCommand command)
        {
            await _mediator.Send(command);
            return Ok("Fuar başarıyla eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFair(int id)
        {
            await _mediator.Send(new RemoveFairCommand(id));
            return Ok("Fuar başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFair(UpdateFairCommand command)
        {
            await _mediator.Send(command);
            return Ok("Fuar başarıyla güncellendi");
        }
    } 
}
