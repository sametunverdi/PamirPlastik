import os
import io

path = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Home\Index.cshtml"
with io.open(path, "r", encoding="utf-8") as f:
    content = f.read()

# Step 4 (Global Network) Replacements
content = content.replace(
    'Global Güç', 
    '@Localizer.Get("Global Güç", "Global Power")'
)
content = content.replace(
    'Dünyanın Her Yerinde <span class="text-[#4A5FC1]">Pamir Plastik</span>',
    '@Html.Raw(Localizer.Get("Dünyanın Her Yerinde <span class=\"text-[#4A5FC1]\">Pamir Plastik</span>", "Pamir Plastik <span class=\"text-[#4A5FC1]\">All Around the World</span>"))'
)
content = content.replace('>Kıta Ağı</div>', '>@Localizer.Get("Kıta Ağı", "Continent Network")</div>')
content = content.replace('>Ürün Çeşidi</div>', '>@Localizer.Get("Ürün Çeşidi", "Product Variety")</div>')

content = content.replace('Online Kataloğumuzu İnceleyin', '@Localizer.Get("Online Kataloğumuzu İnceleyin", "Review Our Online Catalog")')
content = content.replace(
    'Tüm ürün gruplarımızı ve teknik detayları içeren güncel kataloğumuza ulaşın.', 
    '@Localizer.Get("Tüm ürün gruplarımızı ve teknik detayları içeren güncel kataloğumuza ulaşın.", "Access our current catalog containing all our product groups and technical details.")'
)
content = content.replace('Teklif Alın', '@Localizer.Get("Teklif Alın", "Get a Quote")')
content = content.replace('>Katalog</a>', '>@Localizer.Get("Katalog", "Catalog")</a>')

with io.open(path, "w", encoding="utf-8") as f:
    f.write(content)

