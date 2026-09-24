using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class AdminJobAppViewFixer
{
    public static void Fix()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Areas\Admin\Views\JobApplication\Index.cshtml";
        string content = File.ReadAllText(path, Encoding.UTF8);
        
        // Remove the confirm() onclick and add deleteAlert(event, this.href)
        content = Regex.Replace(content, @"onclick=""return confirm\('.*?'\)""", @"onclick=""deleteAlert(event, this.href)""");
        
        // Add the script block at the end
        string scriptBlock = @"
<script>
    function deleteAlert(e, url) {
        e.preventDefault();
        Swal.fire({
            title: 'Emin misiniz?',
            text: 'Bu iş başvurusunu kalıcı olarak silmek istediğinize emin misiniz?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#ef4444',
            cancelButtonColor: '#64748b',
            confirmButtonText: 'Evet, Sil!',
            cancelButtonText: 'İptal'
        }).then((result) => {
            if (result.isConfirmed) {
                window.location.href = url;
            }
        });
    }

    @if (TempData[""SuccessMessage""] != null)
    {
        <text>
        Swal.fire({
            title: 'Başarılı!',
            text: @Html.Raw(Json.Serialize(TempData[""SuccessMessage""])),
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
            text: @Html.Raw(Json.Serialize(TempData[""ErrorMessage""])),
            icon: 'error',
            confirmButtonText: 'Tamam',
            confirmButtonColor: '#ef4444'
        });
        </text>
    }
</script>
";
        
        // Convert scriptBlock to base64 and decode to ensure perfect encoding without compiler issues
        string b64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(scriptBlock));
        string decodedScript = Encoding.UTF8.GetString(Convert.FromBase64String(b64));
        
        content = content + "\n" + decodedScript;
        
        File.WriteAllText(path, content, new UTF8Encoding(false));
    }
}
