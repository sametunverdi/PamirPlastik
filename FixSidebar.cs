using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class AdminSidebarFixer
{
    public static void Fix()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Areas\Admin\Views\Shared\_AdminLayout.cshtml";
        // It's likely UTF-8 but containing replacement chars. Let's just find the exact block and replace it.
        string content = File.ReadAllText(path, Encoding.UTF8);
        
        string correctSpan = "<span class=\"text-sm tracking-wide\">İş Başvuruları</span>";
        // Because the  is actually the Unicode replacement character, regex matching might be tricky.
        // We can just match the <i> tag and the </a> tag.
        
        content = Regex.Replace(content, @"<i class=""fa-solid fa-briefcase @GetIconClass\(""/admin/jobapplication""\)""></i>.*?</a>", @"<i class=""fa-solid fa-briefcase @GetIconClass(""/admin/jobapplication"")""></i> " + correctSpan + "\n                        </a>", RegexOptions.Singleline);
        
        File.WriteAllText(path, content, new UTF8Encoding(false));
    }
}
