using MediatR;

namespace PamirPlastik.Application.Features.Mediator.Commands.ColorCommands
{
    public class UpdateColorCommand : IRequest
    {
        public int ColorID { get; set; }
        public string? Name_TR { get; set; }
        public string? Name_EN { get; set; }
        public string? HexCode { get; set; }
    }
}