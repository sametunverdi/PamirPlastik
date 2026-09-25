import os
import io

path = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Home\Index.cshtml"
with io.open(path, "r", encoding="utf-8") as f:
    content = f.read()

content = content.replace(
    '@Html.Raw(Localizer.Get("Dünyanın Her Yerinde <span class=\"\"text-[#4A5FC1]\"\">Pamir Plastik</span>", "Pamir Plastik <span class=\"\"text-[#4A5FC1]\"\">All Around the World</span>"))',
    '@Html.Raw(Localizer.Get("Dünyanın Her Yerinde <span class=\\"text-[#4A5FC1]\\">Pamir Plastik</span>", "Pamir Plastik <span class=\\"text-[#4A5FC1]\\">All Around the World</span>"))'
)

with io.open(path, "w", encoding="utf-8") as f:
    f.write(content)
