import os
import re

mig_dir = r"c:\Users\Samet\Desktop\Project\PamirPlastik\Infrastructure\PamirPlastik.Persistence\Migrations"
mig_file = None

for f in os.listdir(mig_dir):
    if f.endswith("_AddHeroBadges_Manual.cs"):
        mig_file = os.path.join(mig_dir, f)
        break

if mig_file:
    with open(mig_file, "r", encoding="utf-8") as file:
        content = file.read()
    
    # We want to replace the body of Up() and Down()
    up_body = """
            migrationBuilder.AddColumn<string>(name: "HeroBadge1_TR", table: "HomePageSettings", type: "nvarchar(max)", nullable: true);
            migrationBuilder.AddColumn<string>(name: "HeroBadge1_EN", table: "HomePageSettings", type: "nvarchar(max)", nullable: true);
            migrationBuilder.AddColumn<string>(name: "HeroBadge2_TR", table: "HomePageSettings", type: "nvarchar(max)", nullable: true);
            migrationBuilder.AddColumn<string>(name: "HeroBadge2_EN", table: "HomePageSettings", type: "nvarchar(max)", nullable: true);
            migrationBuilder.AddColumn<string>(name: "HeroBadge3_TR", table: "HomePageSettings", type: "nvarchar(max)", nullable: true);
            migrationBuilder.AddColumn<string>(name: "HeroBadge3_EN", table: "HomePageSettings", type: "nvarchar(max)", nullable: true);
    """
    
    down_body = """
            migrationBuilder.DropColumn(name: "HeroBadge1_TR", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge1_EN", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge2_TR", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge2_EN", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge3_TR", table: "HomePageSettings");
            migrationBuilder.DropColumn(name: "HeroBadge3_EN", table: "HomePageSettings");
    """
    
    content = re.sub(r'protected override void Up\(MigrationBuilder migrationBuilder\)\s*\{[\s\S]*?\}\s*protected override void Down', 
                     f'protected override void Up(MigrationBuilder migrationBuilder)\n        {{{up_body}}}\n\n        protected override void Down', content)
                     
    content = re.sub(r'protected override void Down\(MigrationBuilder migrationBuilder\)\s*\{[\s\S]*?\}',
                     f'protected override void Down(MigrationBuilder migrationBuilder)\n        {{{down_body}}}', content)

    with open(mig_file, "w", encoding="utf-8") as file:
        file.write(content)
    print("Migration patched successfully.")
else:
    print("Migration file not found.")
