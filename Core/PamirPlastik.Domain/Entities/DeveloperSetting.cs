using System;

namespace PamirPlastik.Domain.Entities
{
    public class DeveloperSetting
    {
        public int DeveloperSettingID { get; set; }
        public string? SignatureText { get; set; }
        public string? DeveloperName { get; set; }
        public string? DeveloperUrl { get; set; }
    }
}
