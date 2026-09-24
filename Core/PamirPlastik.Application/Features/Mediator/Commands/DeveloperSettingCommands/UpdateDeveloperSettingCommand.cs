using MediatR;

namespace PamirPlastik.Application.Features.Mediator.Commands.DeveloperSettingCommands
{
    public class UpdateDeveloperSettingCommand : IRequest
    {
        public int DeveloperSettingID { get; set; }
        public string? SignatureText { get; set; }
        public string? DeveloperName { get; set; }
        public string? DeveloperUrl { get; set; }
    }
}
