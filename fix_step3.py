import os
import io

path = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Home\Index.cshtml"
with io.open(path, "r", encoding="utf-8") as f:
    content = f.read()

# Production Capacity Section Replacements
content = content.replace(
    'string.IsNullOrEmpty(Model.ProdTitleTop_TR) ? "PAMİR PLASTİK GÜVENCESİYLE" : Model.ProdTitleTop_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdTitleTop_EN) ? Model.ProdTitleTop_EN : Model.ProdTitleTop_TR) ?? (Localizer.CurrentLanguage == "en" ? "WITH THE ASSURANCE OF PAMIR PLASTIK" : "PAMİR PLASTİK GÜVENCESİYLE")'
)

content = content.replace(
    'string.IsNullOrEmpty(Model.ProdTitleMain_TR) ? "Sadece Üretmiyor, <br/><span class=\"text-blue-500/80\">Değer Katıyoruz.</span>" : Model.ProdTitleMain_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdTitleMain_EN) ? Model.ProdTitleMain_EN : Model.ProdTitleMain_TR) ?? (Localizer.CurrentLanguage == "en" ? "We Don\'t Just Produce, <br/><span class=\"text-blue-500/80\">We Add Value.</span>" : "Sadece Üretmiyor, <br/><span class=\"text-blue-500/80\">Değer Katıyoruz.</span>")'
)

content = content.replace(
    'string.IsNullOrEmpty(Model.ProdDescription_TR) ? "Sektördeki 25 yıllık deneyimimizle, en son teknolojiye sahip makine parkurumuzda ev aletlerinden ofis kırtasiye ve banyo ürünlerine kadar binlerce ürün üretiyoruz." : Model.ProdDescription_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdDescription_EN) ? Model.ProdDescription_EN : Model.ProdDescription_TR) ?? (Localizer.CurrentLanguage == "en" ? "With our 25 years of experience in the sector, we produce thousands of products from home appliances to office stationery and bathroom products in our state-of-art machinery park." : "Sektördeki 25 yıllık deneyimimizle, en son teknolojiye sahip makine parkurumuzda ev aletlerinden ofis kırtasiye ve banyo ürünlerine kadar binlerce ürün üretiyoruz.")'
)

content = content.replace(
    'string.IsNullOrEmpty(Model.ProdItem1Title_TR) ? "Geniş Makine Parkuru" : Model.ProdItem1Title_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdItem1Title_EN) ? Model.ProdItem1Title_EN : Model.ProdItem1Title_TR) ?? (Localizer.CurrentLanguage == "en" ? "Wide Machinery Park" : "Geniş Makine Parkuru")'
)
content = content.replace(
    'string.IsNullOrEmpty(Model.ProdItem1Desc_TR) ? "Kendi bünyemizdeki yüksek teknoloji üretim bantlarıyla sınır tanımıyoruz." : Model.ProdItem1Desc_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdItem1Desc_EN) ? Model.ProdItem1Desc_EN : Model.ProdItem1Desc_TR) ?? (Localizer.CurrentLanguage == "en" ? "We know no boundaries with our in-house high-tech production lines." : "Kendi bünyemizdeki yüksek teknoloji üretim bantlarıyla sınır tanımıyoruz.")'
)

content = content.replace(
    'string.IsNullOrEmpty(Model.ProdItem2Title_TR) ? "Sertifikalı Kalite" : Model.ProdItem2Title_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdItem2Title_EN) ? Model.ProdItem2Title_EN : Model.ProdItem2Title_TR) ?? (Localizer.CurrentLanguage == "en" ? "Certified Quality" : "Sertifikalı Kalite")'
)
content = content.replace(
    'string.IsNullOrEmpty(Model.ProdItem2Desc_TR) ? "Üretimin her aşamasında uluslararası standartlara uygun sürdürülebilir kalite kontrolü." : Model.ProdItem2Desc_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdItem2Desc_EN) ? Model.ProdItem2Desc_EN : Model.ProdItem2Desc_TR) ?? (Localizer.CurrentLanguage == "en" ? "Sustainable quality control in accordance with international standards at every stage of production." : "Üretimin her aşamasında uluslararası standartlara uygun sürdürülebilir kalite kontrolü.")'
)

content = content.replace(
    'string.IsNullOrEmpty(Model.ProdItem3Title_TR) ? "Global Lojistik Ağı" : Model.ProdItem3Title_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdItem3Title_EN) ? Model.ProdItem3Title_EN : Model.ProdItem3Title_TR) ?? (Localizer.CurrentLanguage == "en" ? "Global Logistics Network" : "Global Lojistik Ağı")'
)
content = content.replace(
    'string.IsNullOrEmpty(Model.ProdItem3Desc_TR) ? "Dünyanın 50\'den fazla ülkesine sorunsuz tedarik ve lojistik operasyonu sunuyoruz." : Model.ProdItem3Desc_TR',
    '(Localizer.CurrentLanguage == "en" && !string.IsNullOrWhiteSpace(Model.ProdItem3Desc_EN) ? Model.ProdItem3Desc_EN : Model.ProdItem3Desc_TR) ?? (Localizer.CurrentLanguage == "en" ? "We offer seamless supply and logistics operations to more than 50 countries around the world." : "Dünyanın 50\'den fazla ülkesine sorunsuz tedarik ve lojistik operasyonu sunuyoruz.")'
)

content = content.replace('>Yıllık Üretim Kapasitesi</div>', '>@Localizer.Get("Yıllık Üretim Kapasitesi", "Annual Production Capacity")</div>')
content = content.replace('Hakkımızda Daha Fazla', '@Localizer.Get("Hakkımızda Daha Fazla", "More About Us")')

# E-Commerce Section Replacements
content = content.replace('E-Ticarette Lider Konum', '@Localizer.Get("E-Ticarette Lider Konum", "Leading Position in E-Commerce")')
content = content.replace('Online\'da Güvenle <br />Alışverişin Adresi', '@Html.Raw(Localizer.Get("Online\'da Güvenle <br />Alışverişin Adresi", "Safe Address for <br />Online Shopping"))')
content = content.replace('Ev ve mutfak gereçlerinde en çok tercih edilen markalardan biri olarak on binlerce mutlu müşteriye ulaşıyoruz.', '@Localizer.Get("Ev ve mutfak gereçlerinde en çok tercih edilen markalardan biri olarak on binlerce mutlu müşteriye ulaşıyoruz.", "As one of the most preferred brands in home and kitchen appliances, we reach tens of thousands of happy customers.")')
content = content.replace('Resmi Mağazamızı Ziyaret Et', '@Localizer.Get("Resmi Mağazamızı Ziyaret Et", "Visit Our Official Store")')
content = content.replace('>Mağaza Puanı</div>', '>@Localizer.Get("Mağaza Puanı", "Store Rating")</div>')
content = content.replace('>Aylık Başarılı Teslimat</div>', '>@Localizer.Get("Aylık Başarılı Teslimat", "Monthly Successful Deliveries")</div>')
content = content.replace('>Gerçek Müşteri Değerlendirmesi</div>', '>@Localizer.Get("Gerçek Müşteri Değerlendirmesi", "Real Customer Reviews")</div>')

with io.open(path, "w", encoding="utf-8") as f:
    f.write(content)

