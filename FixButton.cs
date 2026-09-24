using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class ContactButtonFixer
{
    public static void Fix()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Contact\Index.cshtml";
        string content = File.ReadAllText(path, Encoding.UTF8);
        
        string newButton = @"<div class=""grid grid-cols-1 md:grid-cols-2 gap-4"">
                            <button type=""submit"" class=""group w-full py-5 bg-[#0f172a] text-white rounded-2xl font-black text-[11px] tracking-[0.3em] uppercase shadow-lg hover:bg-pamir-brand transition-all flex items-center justify-center gap-3 active:scale-[0.98]"">
                                <span>MESAJI GÖNDER</span>
                                <i class=""fa-solid fa-paper-plane transform group-hover:translate-x-1 group-hover:-translate-y-1 transition-transform text-[#ffda44]""></i>
                            </button>
                            <button type=""button"" onclick=""document.getElementById('jobApplicationModal').classList.remove('hidden')"" class=""group w-full py-5 bg-white border-2 border-[#0f172a] text-[#0f172a] rounded-2xl font-black text-[11px] tracking-[0.3em] uppercase hover:bg-gray-50 transition-all flex items-center justify-center gap-3 active:scale-[0.98]"">
                                <span>İŞ BAŞVURUSU YAP</span>
                                <i class=""fa-solid fa-briefcase text-pamir-brand""></i>
                            </button>
                        </div>";
        
        // Find the button type="submit" and replace it
        // The regex matches from <button type="submit" down to </button>
        content = Regex.Replace(content, @"<button type=""submit"" class=""group w-full py-6.*?<\/button>", newButton, RegexOptions.Singleline);
        
        File.WriteAllText(path, content, new UTF8Encoding(false));
    }
}
