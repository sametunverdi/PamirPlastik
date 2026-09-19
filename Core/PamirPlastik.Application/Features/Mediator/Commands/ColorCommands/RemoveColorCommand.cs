using MediatR;

namespace PamirPlastik.Application.Features.Mediator.Commands.ColorCommands
{
    public class RemoveColorCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveColorCommand(int id)
        {
            Id = id;
        }
    }
}