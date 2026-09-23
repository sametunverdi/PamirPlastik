using MediatR;
namespace PamirPlastik.Application.Features.Mediator.Commands.FairCommands
{
    public class RemoveFairCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveFairCommand(int id) { Id = id; }
    }
}
