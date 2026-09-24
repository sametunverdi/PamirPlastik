using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class SweetAlertFixer
{
    public static void Fix()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Contact\Index.cshtml";
        string content = File.ReadAllText(path, Encoding.UTF8);
        
        string newScript = @"<script>
    @if (TempData[""SuccessMessage""] != null)
    {
        <text>
        Swal.fire({
            title: 'Başarılı!',
            text: '@Html.Raw(TempData[""SuccessMessage""])',
            icon: 'success',
            confirmButtonText: 'Tamam',
            confirmButtonColor: '#0f172a'
        });
        </text>
    }
    @if (TempData[""ErrorMessage""] != null)
    {
        <text>
        Swal.fire({
            title: 'Hata!',
            text: '@Html.Raw(TempData[""ErrorMessage""])',
            icon: 'error',
            confirmButtonText: 'Tamam',
            confirmButtonColor: '#ef4444'
        });
        </text>
    }
</script>";

        // Encode to UTF8 bytes directly using C# strings
        // Wait, since I'm compiling this script directly via Add-Type, the C# compiler inside powershell might misinterpret "Başarılı!" if powershell feeds it bad bytes.
        // Let's use Base64 for the replacement block to be 100% safe.
        
        string b64 = "PHNjcmlwdD4KICAgIEBpZiAoVGVtcERhdGFbIlN1Y2Nlc3NNZXNzYWdlIl0gIT0gbnVsbCkKICAgIHsKICAgICAgICA8dGV4dD4KICAgICAgICBTd2FsLmZpcmUoewogICAgICAgICAgICB0aXRsZTogJ0JhxZ9hcsSxbMSxIScsCiAgICAgICAgICAgIHRleHQ6ICdASHRtbC5SYXcoVGVtcERhdGFbIlN1Y2Nlc3NNZXNzYWdlIl0pJywKICAgICAgICAgICAgaWNvbjogJ3N1Y2Nlc3MnLAogICAgICAgICAgICBjb25maXJtQnV0dG9uVGV4dDogJ1RhbWFtJywKICAgICAgICAgICAgY29uZmlybUJ1dHRvbkNvbG9yOiAnIzBmMTcyYScKICAgICAgICB9KTsKICAgICAgICA8L3RleHQ+CiAgICB9CiAgICBAaWYgKFRlbXBEYXRhWyJFcnJvck1lc3NhZ2UiXSAhPSBudWxsKQogICAgewogICAgICAgIDx0ZXh0PgogICAgICAgIFN3YWwuZmlyZSh7CiAgICAgICAgICAgIHRpdGxlOiAnSGF0YSEnLAogICAgICAgICAgICB0ZXh0OiAnQEh0bWwuUmF3KFRlbXBEYXRhWyJFcnJvck1lc3NhZ2UiXSknLAogICAgICAgICAgICBpY29uOiAnZXJyb3InLAogICAgICAgICAgICBjb25maXJtQnV0dG9uVGV4dDogJ1RhbWFtJywKICAgICAgICAgICAgY29uZmlybUJ1dHRvbkNvbG9yOiAnI2VmNDQ0NCcKICAgICAgICB9KTsKICAgICAgICA8L3RleHQ+CiAgICB9Cjwvc2NyaXB0Pg==";
        string decodedScript = Encoding.UTF8.GetString(Convert.FromBase64String(b64));
        
        // Find the existing script block
        content = Regex.Replace(content, @"(?s)<script>\s*@if \(TempData.*?<\/script>", decodedScript);
        
        File.WriteAllText(path, content, new UTF8Encoding(false));
    }
}
