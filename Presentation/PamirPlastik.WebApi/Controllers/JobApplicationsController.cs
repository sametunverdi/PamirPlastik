using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.JobApplicationCommands;
using PamirPlastik.Application.Features.Mediator.Queries.JobApplicationQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public JobApplicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> JobApplicationList()
        {
            var values = await _mediator.Send(new GetJobApplicationQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobApplication(int id)
        {
            var value = await _mediator.Send(new GetJobApplicationByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobApplication(CreateJobApplicationCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ýþ baþvurusu baþarýyla alýndý.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveJobApplication(int id)
        {
            await _mediator.Send(new RemoveJobApplicationCommand(id));
            return Ok("Ýþ baþvurusu baþarýyla silindi.");
        }
    }
}
