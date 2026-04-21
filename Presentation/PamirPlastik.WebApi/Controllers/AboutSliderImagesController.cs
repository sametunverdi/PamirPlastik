using MediatR;
using Microsoft.AspNetCore.Mvc;
using PamirPlastik.Application.Features.Mediator.Commands.AboutSliderImageCommands;
using PamirPlastik.Application.Features.Mediator.Queries.AboutSliderImageQueries;
using System.Threading.Tasks;

namespace PamirPlastik.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutSliderImagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutSliderImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AboutSliderImageList()
        {
            var values = await _mediator.Send(new GetAboutSliderImageQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutSliderImage(int id)
        {
            var values = await _mediator.Send(new GetAboutSliderImageByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutSliderImage(CreateAboutSliderImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımızda Slider Görseli Başarıyla Eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAboutSliderImage(UpdateAboutSliderImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımızda Slider Görseli Başarıyla Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAboutSliderImage(int id)
        {
            await _mediator.Send(new RemoveAboutSliderImageCommand(id));
            return Ok("Hakkımızda Slider Görseli Başarıyla Silindi");
        }
    }
}