using MediatR;
namespace PamirPlastik.Application.Features.Mediator.Commands.HomePageSettingCommands
{
    public class RemoveHomePageSettingCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveHomePageSettingCommand(int id) { Id = id; }
    }
}
