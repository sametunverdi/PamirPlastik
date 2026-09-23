using MediatR;
namespace PamirPlastik.Application.Features.Mediator.Commands.FairCommands
{
    public class UpdateFairCommand : IRequest
    {
        public int FairID { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Date { get; set; }
        public string? Stand { get; set; }
        public string? Img1 { get; set; }
        public string? Img2 { get; set; }
        public bool IsFuture { get; set; }
    }
}
