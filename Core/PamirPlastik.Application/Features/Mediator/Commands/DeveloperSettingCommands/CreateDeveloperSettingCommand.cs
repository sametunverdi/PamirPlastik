using MediatR;

namespace PamirPlastik.Application.Features.Mediator.Commands.DeveloperSettingCommands
{
    public class CreateDeveloperSettingCommand : IRequest
    {
        public string? SignatureText { get; set; }
        public string? DeveloperName { get; set; }
        public string? DeveloperUrl { get; set; }
    }
}
