using MediatR;
namespace PamirPlastik.Application.Features.Mediator.Commands.JobApplicationCommands
{
    public class RemoveJobApplicationCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveJobApplicationCommand(int id) { Id = id; }
    }
}
