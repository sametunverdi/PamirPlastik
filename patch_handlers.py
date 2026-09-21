import os
import re

handlers_dir = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Core\PamirPlastik.Application\Features\Mediator\Handlers\HomePageSettingHandlers"

badges_req = """
                HeroBadge1_TR = request.HeroBadge1_TR,
                HeroBadge1_EN = request.HeroBadge1_EN,
                HeroBadge2_TR = request.HeroBadge2_TR,
                HeroBadge2_EN = request.HeroBadge2_EN,
                HeroBadge3_TR = request.HeroBadge3_TR,
                HeroBadge3_EN = request.HeroBadge3_EN,"""

badges_val = """
                HeroBadge1_TR = value.HeroBadge1_TR,
                HeroBadge1_EN = value.HeroBadge1_EN,
                HeroBadge2_TR = value.HeroBadge2_TR,
                HeroBadge2_EN = value.HeroBadge2_EN,
                HeroBadge3_TR = value.HeroBadge3_TR,
                HeroBadge3_EN = value.HeroBadge3_EN,"""

badges_x = """
                HeroBadge1_TR = x.HeroBadge1_TR,
                HeroBadge1_EN = x.HeroBadge1_EN,
                HeroBadge2_TR = x.HeroBadge2_TR,
                HeroBadge2_EN = x.HeroBadge2_EN,
                HeroBadge3_TR = x.HeroBadge3_TR,
                HeroBadge3_EN = x.HeroBadge3_EN,"""


for filename in os.listdir(handlers_dir):
    if filename.endswith(".cs"):
        filepath = os.path.join(handlers_dir, filename)
        with open(filepath, "r", encoding="utf-8") as f:
            content = f.read()

        if "UpdateHomePageSettingCommandHandler" in filename:
            content = re.sub(
                r"(value\.HeroImageUrl\s*=\s*request\.HeroImageUrl;)",
                r"\1\n            value.HeroBadge1_TR = request.HeroBadge1_TR;\n            value.HeroBadge1_EN = request.HeroBadge1_EN;\n            value.HeroBadge2_TR = request.HeroBadge2_TR;\n            value.HeroBadge2_EN = request.HeroBadge2_EN;\n            value.HeroBadge3_TR = request.HeroBadge3_TR;\n            value.HeroBadge3_EN = request.HeroBadge3_EN;",
                content
            )
        elif "CreateHomePageSettingCommandHandler" in filename:
            content = re.sub(
                r"(HeroImageUrl\s*=\s*request\.HeroImageUrl,)",
                r"\1" + badges_req,
                content
            )
        elif "GetHomePageSettingQueryHandler" in filename: 
            content = re.sub(
                r"(HeroImageUrl\s*=\s*x\.HeroImageUrl,)",
                r"\1" + badges_x,
                content
            )
        elif "GetHomePageSettingByIdQueryHandler" in filename: 
            content = re.sub(
                r"(HeroImageUrl\s*=\s*value\.HeroImageUrl,)",
                r"\1" + badges_val,
                content
            )

        with open(filepath, "w", encoding="utf-8") as f:
            f.write(content)

print("Handlers patched.")
