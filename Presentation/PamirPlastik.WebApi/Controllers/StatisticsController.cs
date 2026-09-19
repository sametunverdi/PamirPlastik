using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Queries.StatisticsQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetDashboardStatistics()
        {
            var values = await _mediator.Send(new GetDashboardStatisticsQuery());
            return Ok(values);
        }
    }
}
