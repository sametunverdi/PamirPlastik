using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class Program {
    public static void Main() {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Controllers\JobApplicationController.cs";
        string content = File.ReadAllText(path, Encoding.UTF8);
        
        string succ = Encoding.UTF8.GetString(Convert.FromBase64String("QmHFn3Z1cnVudXogYmHFn2FyxLFsYSBhbMSxbm3EscWfdMSxci4gxLBuc2FuIGtheW5ha2xhcsSxIGVraWJpbWl6IGVuIGvEsXNhIHPDvHJlZGUgQ1Ynbml6aSBpbmNlbGV5ZWNla3Rpci4="));
        string err = Encoding.UTF8.GetString(Convert.FromBase64String("QmHFn3Z1cnVudXogZ8O2bmRlcmlsaXJrZW4gYmlyIGhhdGEgb2x1xZ90dS4gTMO8dGZlbiB0ZWtyYXIgZGVuZXlpbi4="));
        
        content = Regex.Replace(content, @"TempData\[""SuccessMessage""\] = "".*?"";", "TempData[\"SuccessMessage\"] = \"" + succ + "\";");
        content = Regex.Replace(content, @"TempData\[""ErrorMessage""\] = "".*?"";", "TempData[\"ErrorMessage\"] = \"" + err + "\";");
        
        File.WriteAllText(path, content, new UTF8Encoding(false));
    }
}
