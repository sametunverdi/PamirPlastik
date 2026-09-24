using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Areas\Admin\Views\Shared\_AdminLayout.cshtml";
        string content = File.ReadAllText(path, Encoding.UTF8);

        // 1. Inject Styles
        if (!content.Contains("<style>")) {
            string style = <style>
        #sidebar nav::-webkit-scrollbar { width: 4px; }
        #sidebar nav::-webkit-scrollbar-track { background: transparent; }
        #sidebar nav::-webkit-scrollbar-thumb { background: #334155; border-radius: 4px; }
        #sidebar nav::-webkit-scrollbar-thumb:hover { background: #ffda44; }
    </style>
</head>;
            content = content.Replace("</head>", style);
        }

        // 2. Change Sidebar Background
        string oldAside = "<aside id=\"sidebar\" class=\"bg-[#1e293b] text-slate-300 w-64 flex-shrink-0 flex flex-col fixed lg:static inset-y-0 left-0 z-50 transform -translate-x-full lg:translate-x-0 transition-all duration-300 ease-in-out shadow-2xl border-r border-slate-700\">";
        string newAside = "<aside id=\"sidebar\" class=\"bg-gradient-to-b from-[#0f172a] via-[#151f32] to-[#050505] text-slate-300 w-64 flex-shrink-0 flex flex-col fixed lg:static inset-y-0 left-0 z-50 transform -translate-x-full lg:translate-x-0 transition-all duration-300 ease-in-out shadow-[10px_0_20px_rgba(0,0,0,0.5)] border-r border-slate-700/50\">";
        content = content.Replace(oldAside, newAside);

        // 3. Update GetLinkClass Active/Normal
        string oldGetLinkActive = "? \"flex items-center px-4 py-2.5 bg-[#4A5FC1]/20 text-white rounded-lg font-bold transition-all border-l-4 border-[#ffda44]\"";
        string newGetLinkActive = "? \"flex items-center px-4 py-2.5 bg-gradient-to-r from-primary-dark/60 to-primary/10 text-white rounded-xl font-bold transition-all shadow-[0_0_15px_rgba(79,70,229,0.15)] border-l-4 border-[#ffda44]\"";
        content = content.Replace(oldGetLinkActive, newGetLinkActive);
        
        string oldGetLinkNormal = ": \"flex items-center px-4 py-2.5 rounded-lg hover:bg-slate-800 hover:text-white transition-all font-medium text-slate-400 group border-l-4 border-transparent\";";
        string newGetLinkNormal = ": \"flex items-center px-4 py-2.5 rounded-xl hover:bg-slate-800/50 hover:text-white transition-all font-medium text-slate-400 group border-l-4 border-transparent hover:border-slate-600\";";
        content = content.Replace(oldGetLinkNormal, newGetLinkNormal);

        // 4. Update GetIconClass Active/Normal
        string oldGetIconActive = "? \"text-[#4A5FC1] w-5 text-center mr-3\"";
        string newGetIconActive = "? \"text-[#ffda44] w-5 text-center mr-3 drop-shadow-[0_0_8px_rgba(255,218,68,0.6)]\"";
        content = content.Replace(oldGetIconActive, newGetIconActive);
        
        string oldGetIconNormal = ": \"text-slate-500 w-5 text-center mr-3 group-hover:text-slate-300 transition-colors\";";
        string newGetIconNormal = ": \"text-slate-500 w-5 text-center mr-3 group-hover:text-white group-hover:-translate-y-1 group-hover:scale-110 transition-all duration-300\";";
        content = content.Replace(oldGetIconNormal, newGetIconNormal);

        // 5. Update Section Headers
        string headerRegex = @"<h3 class=\"px-4 text-xs font-bold text-slate-500 uppercase tracking-wider mb-2\">(.*?)</h3>";
        string newHeader = "<div class=\"relative mt-6 mb-3\">\n                <h3 class=\"px-4 text-[10px] font-black text-slate-400 uppercase tracking-[0.2em] mb-2\"></h3>\n                <div class=\"absolute bottom-0 left-4 w-[80%] h-[1px] bg-gradient-to-r from-[#ffda44]/40 via-slate-700/50 to-transparent\"></div>\n            </div>";
        content = Regex.Replace(content, headerRegex, newHeader);

        File.WriteAllText(path, content, Encoding.UTF8);
        Console.WriteLine("Done!");
    }
}