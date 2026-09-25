import os
import io

path = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Shared\Components\_DefaultFeaturedProductsComponentPartial\Default.cshtml"
with io.open(path, "r", encoding="utf-8") as f:
    content = f.read()

content = content.replace(
    'settings?.FeatTitleTop_TR ?? "Sürdürülebilir Kalite"',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(settings?.FeatTitleTop_EN) ? settings?.FeatTitleTop_EN : settings?.FeatTitleTop_TR) ?? (Localizer.CurrentLanguage == "en" ? "Sustainable Quality" : "Sürdürülebilir Kalite")'
)

content = content.replace(
    'settings?.FeatTitleMain_TR ?? "Vitrindeki <span class=\"text-green-600\">Yıldız</span> Ürünler"',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(settings?.FeatTitleMain_EN) ? settings?.FeatTitleMain_EN : settings?.FeatTitleMain_TR) ?? (Localizer.CurrentLanguage == "en" ? "Featured <span class=\\"text-green-600\\">Star</span> Products" : "Vitrindeki <span class=\\"text-green-600\\">Yıldız</span> Ürünler")'
)

content = content.replace(
    '@item.Name_TR',
    '@(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(item.Name_EN) ? item.Name_EN : item.Name_TR)'
)

content = content.replace(
    '@item.ShortDescription_TR',
    '@(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(item.ShortDescription_EN) ? item.ShortDescription_EN : item.ShortDescription_TR)'
)

content = content.replace(
    '@item.Slug_TR',
    '@(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(item.Slug_EN) ? item.Slug_EN : item.Slug_TR)'
)

content = content.replace('Öne Çıkan', '@Localizer.Get("Öne Çıkan", "Featured")')
content = content.replace('Detayları İncele', '@Localizer.Get("Detayları İncele", "View Details")')
content = content.replace('Henüz öne çıkan ürün eklenmemiş.', '@Localizer.Get("Henüz öne çıkan ürün eklenmemiş.", "No featured products added yet.")')

injectStr = "@inject PamirPlastik.WebUI.Services.LocalizationService Localizer\n"
content = injectStr + content

with io.open(path, "w", encoding="utf-8") as f:
    f.write(content)
