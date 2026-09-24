using MediatR;

namespace PamirPlastik.Application.Features.Mediator.Commands.DeveloperSettingCommands
{
    public class RemoveDeveloperSettingCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveDeveloperSettingCommand(int id) { Id = id; }
    }
}
