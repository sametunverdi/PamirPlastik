import os

path = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Home\Index.cshtml"
with open(path, "r", encoding="utf-8") as f:
    content = f.read()

content = content.replace(
    "@Model.HeroTitleTop_TR",
    "@(Localizer.CurrentLanguage == \"en\" && !string.IsNullOrWhiteSpace(Model.HeroTitleTop_EN) ? Model.HeroTitleTop_EN : Model.HeroTitleTop_TR)"
)

content = content.replace(
    "@Html.Raw(Model.HeroTitleMain_TR)",
    "@Html.Raw(Localizer.CurrentLanguage == \"en\" && !string.IsNullOrWhiteSpace(Model.HeroTitleMain_EN) ? Model.HeroTitleMain_EN : Model.HeroTitleMain_TR)"
)

content = content.replace(
    "@Model.HeroDescription_TR",
    "@(Localizer.CurrentLanguage == \"en\" && !string.IsNullOrWhiteSpace(Model.HeroDescription_EN) ? Model.HeroDescription_EN : Model.HeroDescription_TR)"
)

content = content.replace(
    "@Model.HeroBadge1_TR",
    "@(Localizer.CurrentLanguage == \"en\" && !string.IsNullOrWhiteSpace(Model.HeroBadge1_EN) ? Model.HeroBadge1_EN : Model.HeroBadge1_TR)"
)
content = content.replace(
    "@Model.HeroBadge2_TR",
    "@(Localizer.CurrentLanguage == \"en\" && !string.IsNullOrWhiteSpace(Model.HeroBadge2_EN) ? Model.HeroBadge2_EN : Model.HeroBadge2_TR)"
)
content = content.replace(
    "@Model.HeroBadge3_TR",
    "@(Localizer.CurrentLanguage == \"en\" && !string.IsNullOrWhiteSpace(Model.HeroBadge3_EN) ? Model.HeroBadge3_EN : Model.HeroBadge3_TR)"
)

content = content.replace("Katalog İndir", "@Localizer.Get(\"Katalog İndir\", \"Download Catalog\")")
content = content.replace("Bize Ulaşın", "@Localizer.Get(\"Bize Ulaşın\", \"Contact Us\")")
content = content.replace(">Sektör Yılı</div>", ">@Localizer.Get(\"Sektör Yılı\", \"Years in Sector\")</div>")
content = content.replace(">Ürün Grupları</div>", ">@Localizer.Get(\"Ürün Grupları\", \"Product Groups\")</div>")
content = content.replace(">İhracat Ülkesi</div>", ">@Localizer.Get(\"İhracat Ülkesi\", \"Export Countries\")</div>")
content = content.replace(">Sürdürülebilir</div>", ">@Localizer.Get(\"Sürdürülebilir\", \"Sustainable\")</div>")
content = content.replace(">Yüksek Kalite</div>", ">@Localizer.Get(\"Yüksek Kalite\", \"High Quality\")</div>")
content = content.replace(">Yenilikçi</div>", ">@Localizer.Get(\"Yenilikçi\", \"Innovative\")</div>")
content = content.replace("ISO Sertifikalı", "@Localizer.Get(\"ISO Sertifikalı\", \"ISO Certified\")")
content = content.replace("Premium Kalite", "@Localizer.Get(\"Premium Kalite\", \"Premium Quality\")")
content = content.replace("Yenilikçi Tasarım", "@Localizer.Get(\"Yenilikçi Tasarım\", \"Innovative Design\")")

with open(path, "w", encoding="utf-8") as f:
    f.write(content)
