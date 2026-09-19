namespace PamirPlastik.Application.Features.Mediator.Results.ColorResults
{
    public class GetColorByIdQueryResult
    {
        public int ColorID { get; set; }
        public string? Name_TR { get; set; }
        public string? Name_EN { get; set; }
        public string? HexCode { get; set; }
    }
}