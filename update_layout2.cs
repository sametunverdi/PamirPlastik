using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Shared\_Layout.cshtml";
        string content = File.ReadAllText(path);

        // 1. Remove Hemen Bizi Arayın block
        string patternCall = @"<div class="px-6 py-8 border-t border-gray-50 bg-white">.*?Hemen Bizi Arayın.*?</div>\s*</div>";
        content = Regex.Replace(content, patternCall, "", RegexOptions.Singleline);

        // 2. Add Job Application to mobile menu (under Contact)
        // Find the Contact mobile menu block
        string patternMobileContact = @"(<a href="/Contact".*?İletişim.*?</a>)";
        
        string newJobApp = @"
            <a href="/Contact/Index?openJobModal=true" class="group flex items-center justify-between py-4 px-5 rounded-2xl bg-gray-50 hover:bg-[#0f172a] transition-all duration-300">
                <div class="flex items-center gap-4">
                    <div class="w-10 h-10 rounded-xl bg-white flex items-center justify-center text-pamir-brand shadow-sm group-hover:bg-[#ffda44] group-hover:text-[#0f172a] transition-all">
                        <i class="fa-solid fa-briefcase text-lg"></i>
                    </div>
                    <span class="text-base font-extrabold text-gray-800 group-hover:text-white transition-colors">İş Başvurusu</span>
                </div>
                <svg class="w-5 h-5 text-gray-300 group-hover:text-[#ffda44] transition-colors" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M9 5l7 7-7 7"></path></svg>
            </a>";

        if (!content.Contains("openJobModal=true")) 
        {
            content = Regex.Replace(content, patternMobileContact, "$1" + newJobApp, RegexOptions.Singleline);
        }

        File.WriteAllText(path, content);
    }
}