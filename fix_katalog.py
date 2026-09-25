import os
import io

path = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Home\Index.cshtml"
with io.open(path, "r", encoding="utf-8") as f:
    content = f.read()

content = content.replace(
    'Katalog\n                    </a>', 
    '@Localizer.Get("Katalog", "Catalog")\n                    </a>'
)
content = content.replace(
    'Katalog\r\n                    </a>', 
    '@Localizer.Get("Katalog", "Catalog")\r\n                    </a>'
)

with io.open(path, "w", encoding="utf-8") as f:
    f.write(content)
