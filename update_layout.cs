using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Shared\_Layout.cshtml";
        string content = File.ReadAllText(path, Encoding.UTF8);

        // 1. Add Job Application to Mobile Menu
        string mobileContactLink = @"<a href="/Contact/Index/" class="relative group py-2 font-semibold text-gray-700 hover:text-[#ffda44] transition-colors">İletişim<span class="absolute bottom-0 left-0 w-0 h-0.5 bg-[#ffda44] shadow-[0_0_10px_#ffda44] transition-all duration-300 group-hover:w-full"></span>
                    </a>";
        // Wait, the mobile contact link has a different structure. Let's find the mobile contact link.
        
        string oldMobileContact = @"<a href="/Contact" class="group flex items-center justify-between py-4 px-5 rounded-2xl bg-[#4A5FC1] shadow-lg shadow-blue-200 transition-all duration-300">
                <div class="flex items-center gap-4">
                    <div class="w-10 h-10 rounded-xl bg-white/20 flex items-center justify-center text-white">
                        <svg class="w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M3 8l7.89 5.26a2 2 0 002.22 0L21 8M5 19h14a2 2 0 002-2V7a2 2 0 00-2-2H5a2 2 0 00-2 2v10a2 2 0 002 2z"></path></svg>
                    </div>
                    <span class="text-base font-extrabold text-white">İletişim</span>
                </div>
                <svg class="w-5 h-5 text-white/50 group-hover:text-[#ffda44] transition-colors" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M9 5l7 7-7 7"></path></svg>
            </a>";

        string newJobApp = @"<a href="/Contact/Index?openJobModal=true" class="group flex items-center justify-between py-4 px-5 rounded-2xl bg-gray-50 hover:bg-[#0f172a] transition-all duration-300">
                <div class="flex items-center gap-4">
                    <div class="w-10 h-10 rounded-xl bg-white flex items-center justify-center text-pamir-brand shadow-sm group-hover:bg-[#ffda44] group-hover:text-[#0f172a] transition-all">
                        <i class="fa-solid fa-briefcase text-lg"></i>
                    </div>
                    <span class="text-base font-extrabold text-gray-800 group-hover:text-white transition-colors">İş Başvurusu</span>
                </div>
                <svg class="w-5 h-5 text-gray-300 group-hover:text-[#ffda44] transition-colors" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M9 5l7 7-7 7"></path></svg>
            </a>";

        content = content.Replace(oldMobileContact, oldMobileContact + Environment.NewLine + Environment.NewLine + "            " + newJobApp);

        // 2. Remove "Hemen Bizi Arayın" block
        string callUsBlock = @"<div class="px-6 py-8 border-t border-gray-50 bg-white">
            <a href="tel:+902125550123" class="relative group flex items-center justify-center gap-3 w-full py-5 bg-[#0f172a] text-white rounded-[1.5rem] font-black shadow-xl shadow-blue-900/10 overflow-hidden transition-all active:scale-95">
                <div class="absolute inset-0 bg-gradient-to-r from-pamir-brand to-blue-500 opacity-0 group-hover:opacity-100 transition-opacity duration-500"></div>
                <div class="relative flex items-center gap-3">
                    <div class="w-8 h-8 rounded-lg bg-[#ffda44] flex items-center justify-center text-[#0f172a]">
                        <svg class="w-4 h-4" fill="none" stroke="currentColor" viewBox="0 0 24 24"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M3 5a2 2 0 012-2h3.28a1 1 0 01.948.684l1.498 4.493a1 1 0 01-.502 1.21l-2.257 1.13a11.042 11.042 0 005.516 5.516l1.13-2.257a1 1 0 011.21-.502l4.493 1.498a1 1 0 01.684.949V19a2 2 0 01-2 2h-1C9.716 21 3 14.284 3 6V5z"></path></svg>
                    </div>
                    <span class="tracking-tight text-lg">Hemen Bizi Arayın</span>
                </div>
            </a>
        </div>";
        content = content.Replace(callUsBlock, "");

        // 3. Desktop Language Flags
        string oldDesktopLang = @"<span class="group-hover:text-[#ffda44] transition-colors">TR</span>";
        string newDesktopLang = @"<span class="text-lg group-hover:scale-110 transition-transform">🇹🇷</span>";
        content = content.Replace(oldDesktopLang, newDesktopLang);
        
        string oldDesktopTRMenu = @"<a href="?lang=tr" class="block px-4 py-2 text-sm font-bold text-pamir-brand bg-blue-50/50">TR - Türkçe</a>";
        string newDesktopTRMenu = @"<a href="?lang=tr" class="block px-4 py-2 text-sm font-bold text-pamir-brand bg-blue-50/50 flex items-center gap-2"><span class="text-lg">🇹🇷</span> Türkçe</a>";
        content = content.Replace(oldDesktopTRMenu, newDesktopTRMenu);

        string oldDesktopENMenu = @"<a href="?lang=en" class="block px-4 py-2 text-sm font-medium text-gray-700 hover:bg-gray-50 hover:text-[#ffda44] transition-colors">EN - English</a>";
        string newDesktopENMenu = @"<a href="?lang=en" class="block px-4 py-2 text-sm font-medium text-gray-700 hover:bg-gray-50 hover:text-[#ffda44] transition-colors flex items-center gap-2"><span class="text-lg">🇬🇧</span> English</a>";
        content = content.Replace(oldDesktopENMenu, newDesktopENMenu);

        // 4. Mobile Language Flags
        string oldMobileLangText = @"<span class="text-sm font-bold text-gray-600 uppercase">Dil / Language: <span class="text-pamir-brand">TR</span></span>";
        string newMobileLangText = @"<span class="text-sm font-bold text-gray-600 uppercase flex items-center gap-2">Dil: <span class="text-xl">🇹🇷</span></span>";
        content = content.Replace(oldMobileLangText, newMobileLangText);

        string oldMobileTRMenu = @"<a href="?lang=tr" class="block py-3 px-4 text-sm font-bold text-pamir-brand bg-blue-50 rounded-xl border-l-4 border-pamir-brand">Türkçe</a>";
        string newMobileTRMenu = @"<a href="?lang=tr" class="flex items-center gap-3 py-3 px-4 text-sm font-bold text-pamir-brand bg-blue-50 rounded-xl border-l-4 border-pamir-brand"><span class="text-xl">🇹🇷</span> Türkçe</a>";
        content = content.Replace(oldMobileTRMenu, newMobileTRMenu);

        string oldMobileENMenu = @"<a href="?lang=en" class="block py-3 px-4 text-sm font-bold text-gray-500 hover:text-pamir-brand transition-colors">English</a>";
        string newMobileENMenu = @"<a href="?lang=en" class="flex items-center gap-3 py-3 px-4 text-sm font-bold text-gray-500 hover:text-pamir-brand transition-colors"><span class="text-xl">🇬🇧</span> English</a>";
        content = content.Replace(oldMobileENMenu, newMobileENMenu);

        File.WriteAllText(path, content, Encoding.UTF8);
    }
}