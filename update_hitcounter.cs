using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml";
        string content = File.ReadAllText(path, Encoding.UTF8);
        
        string oldText = @"<!-- Sosyal Medya -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-amber-500/20 blur-3xl rounded-full group-hover:bg-amber-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Sosyal Medya</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-amber-400 to-yellow-300">@ViewBag.TotalSocialMediaCount</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-amber-500/10 border border-amber-500/20 flex items-center justify-center text-amber-400 shadow-[0_0_15px_rgba(245,158,11,0.3)]">
                <i class="fa-solid fa-hashtag text-xl"></i>
            </div>
        </div>
    </div>".Replace(""", "\");

        string newText = @"<!-- Site Ziyaretçisi -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-amber-500/20 blur-3xl rounded-full group-hover:bg-amber-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Toplam Ziyaretçi</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-amber-400 to-yellow-300">@ViewBag.TotalVisitorCount</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-amber-500/10 border border-amber-500/20 flex items-center justify-center text-amber-400 shadow-[0_0_15px_rgba(245,158,11,0.3)]">
                <i class="fa-solid fa-users text-xl"></i>
            </div>
        </div>
    </div>".Replace(""", "\");
        
        content = content.Replace(oldText, newText);
        File.WriteAllText(path, content, Encoding.UTF8);
    }
}