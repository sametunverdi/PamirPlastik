import os
import io

path = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Home\Index.cshtml"
with io.open(path, "r", encoding="utf-8") as f:
    content = f.read()

content = content.replace(
    'class=\"\"text-[#4A5FC1]\"\"',
    'class=\\\"text-[#4A5FC1]\\\"'
)

with io.open(path, "w", encoding="utf-8") as f:
    f.write(content)
