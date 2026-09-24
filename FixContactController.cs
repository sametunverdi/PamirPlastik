using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class ContactControllerFixer
{
    public static void Fix()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Controllers\ContactController.cs";
        string content = File.ReadAllText(path, Encoding.UTF8);
        
        string succ = Encoding.UTF8.GetString(Convert.FromBase64String("TWVzYWrEsW7EsXogYmHFn2FyxLFsYSBnw7ZuZGVyaWxkaS4gRW4ga8Sxc2Egc8O8cmVkZSBzaXplIGTDtm7DvMWfIHlhcGFjYcSfxLF6Lg==")); // Mesajınız başarıyla gönderildi. En kısa sürede size dönüş yapacağız.
        string err = Encoding.UTF8.GetString(Convert.FromBase64String("TWVzYWrEsW7EsXogZ8O2bmRlcmlsaXJrZW4gYmlyIGhhdGEgb2x1xZ90dS4=")); // Mesajınız gönderilirken bir hata oluştu.
        
        string newSuccessBlock = $@"
            if (responseMessage.IsSuccessStatusCode)
            {{
                TempData[""SuccessMessage""] = ""{succ}"";
                return RedirectToAction(""Index"");
            }}
            TempData[""ErrorMessage""] = ""{err}"";
            return View();";
            
        content = Regex.Replace(content, @"if \(responseMessage\.IsSuccessStatusCode\)\s*\{\s*return RedirectToAction\(""Index""\);\s*\}\s*return View\(\);", newSuccessBlock);
        
        File.WriteAllText(path, content, new UTF8Encoding(false));
    }
}
