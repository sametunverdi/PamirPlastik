namespace PamirPlastik.Application.Features.Mediator.Results.DeveloperSettingResults
{
    public class GetDeveloperSettingByIdQueryResult
    {
        public int DeveloperSettingID { get; set; }
        public string? SignatureText { get; set; }
        public string? DeveloperName { get; set; }
        public string? DeveloperUrl { get; set; }
    }
}
