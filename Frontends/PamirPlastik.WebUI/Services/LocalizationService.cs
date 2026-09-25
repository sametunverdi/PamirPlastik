using System;
using System.Collections.Generic;
using System.Threading;

namespace PamirPlastik.WebUI.Services
{
    public class LocalizationService
    {
        public string CurrentLanguage => Thread.CurrentThread.CurrentCulture.Name.StartsWith("en") ? "en" : "tr";

        private readonly Dictionary<string, string> _commonTranslations = new(StringComparer.OrdinalIgnoreCase)
        {
            { "Kırmızı", "Red" },
            { "Mavi", "Blue" },
            { "Antrasit", "Anthracite" },
            { "Beyaz", "White" },
            { "Siyah", "Black" },
            { "Şeffaf", "Transparent" },
            { "Mor", "Purple" },
            { "Sarı", "Yellow" },
            { "Yeşil", "Green" },
            { "Gri", "Grey" },
            { "Pembe", "Pink" },
            { "Turuncu", "Orange" },
            { "Kahverengi", "Brown" }
        };

        public string Get(string trText, string enText)
        {
            if (CurrentLanguage == "en")
            {
                if (!string.IsNullOrWhiteSpace(enText))
                    return enText;

                if (!string.IsNullOrWhiteSpace(trText) && _commonTranslations.TryGetValue(trText.Trim(), out var translated))
                    return translated;
            }
            return trText;
        }
    }
}
