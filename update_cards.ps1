$path = "c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml"
$content = [System.IO.File]::ReadAllText($path, [System.Text.Encoding]::UTF8)

$startToken = '<!-- 4 FIRE CARDS -->'
$endToken = '<!-- CHARTS SECTION -->'

$startIndex = $content.IndexOf($startToken)
$endIndex = $content.IndexOf($endToken)

if ($startIndex -ge 0 -and $endIndex -gt $startIndex) {
    $newCards = @"
<!-- 8 FIRE CARDS -->
<div class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-6 mb-10">
    
    <!-- Toplam Ürün -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-blue-500/20 blur-3xl rounded-full group-hover:bg-blue-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Toplam Ürün</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-blue-400 to-cyan-300">@ViewBag.ProductCount</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-blue-500/10 border border-blue-500/20 flex items-center justify-center text-blue-400 shadow-[0_0_15px_rgba(59,130,246,0.3)]">
                <i class="fa-solid fa-box-open text-xl"></i>
            </div>
        </div>
    </div>

    <!-- Kategoriler -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-purple-500/20 blur-3xl rounded-full group-hover:bg-purple-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Kategoriler</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-purple-400 to-pink-400">@ViewBag.CategoryCount</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-purple-500/10 border border-purple-500/20 flex items-center justify-center text-purple-400 shadow-[0_0_15px_rgba(168,85,247,0.3)]">
                <i class="fa-solid fa-layer-group text-xl"></i>
            </div>
        </div>
    </div>

    <!-- Tüm Mesajlar -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-cyan-500/20 blur-3xl rounded-full group-hover:bg-cyan-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Toplam Mesaj</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-cyan-400 to-teal-300">@ViewBag.TotalContactMessageCount</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-cyan-500/10 border border-cyan-500/20 flex items-center justify-center text-cyan-400 shadow-[0_0_15px_rgba(6,182,212,0.3)]">
                <i class="fa-solid fa-comments text-xl"></i>
            </div>
        </div>
    </div>

    <!-- İş Başvuruları -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-pink-500/20 blur-3xl rounded-full group-hover:bg-pink-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">İş Başvuruları</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-pink-400 to-rose-400">@ViewBag.TotalJobApplicationCount</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-pink-500/10 border border-pink-500/20 flex items-center justify-center text-pink-400 shadow-[0_0_15px_rgba(236,72,153,0.3)]">
                <i class="fa-solid fa-user-tie text-xl"></i>
            </div>
        </div>
    </div>

    <!-- Renk Seçenekleri -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-emerald-500/20 blur-3xl rounded-full group-hover:bg-emerald-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Renk Seçeneği</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-emerald-400 to-green-300">@ViewBag.TotalColorCount</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-emerald-500/10 border border-emerald-500/20 flex items-center justify-center text-emerald-400 shadow-[0_0_15px_rgba(16,185,129,0.3)]">
                <i class="fa-solid fa-palette text-xl"></i>
            </div>
        </div>
    </div>

    <!-- Toplam Fuar -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-teal-500/20 blur-3xl rounded-full group-hover:bg-teal-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Etkinlik/Fuar</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-teal-400 to-emerald-300">@ViewBag.TotalFairCount</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-teal-500/10 border border-teal-500/20 flex items-center justify-center text-teal-400 shadow-[0_0_15px_rgba(20,184,166,0.3)]">
                <i class="fa-solid fa-calendar-alt text-xl"></i>
            </div>
        </div>
    </div>

    <!-- Okunmamış Mesajlar -->
    <a href="/Admin/Message" class="block relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-red-500/30 shadow-[0_10px_30px_rgba(220,38,38,0.15)] group hover:-translate-y-2 transition-all duration-300 cursor-pointer">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-red-500/20 blur-3xl rounded-full group-hover:bg-red-500/40 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Bekleyen Mesaj</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-red-400 to-orange-400">@ViewBag.UnreadMessageCount</h3>
            </div>
            <div class="relative w-12 h-12 rounded-2xl bg-red-500/10 border border-red-500/20 flex items-center justify-center text-red-400 shadow-[0_0_15px_rgba(239,68,68,0.4)]">
                <i class="fa-solid fa-envelope-open-text text-xl group-hover:scale-110 transition-transform"></i>
                @if(ViewBag.UnreadMessageCount > 0)
                {
                    <div class="absolute -top-1 -right-1 w-3 h-3 bg-red-500 rounded-full animate-ping"></div>
                    <div class="absolute -top-1 -right-1 w-3 h-3 bg-red-500 border border-[#0f172a] rounded-full"></div>
                }
            </div>
        </div>
    </a>

    <!-- Site Trafiği (Placeholder Analytics) -->
    <div class="relative bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-6 overflow-hidden border border-slate-700/50 shadow-[0_10px_30px_rgba(0,0,0,0.2)] group hover:-translate-y-2 transition-all duration-300">
        <div class="absolute -right-6 -top-6 w-32 h-32 bg-amber-500/20 blur-3xl rounded-full group-hover:bg-amber-500/30 transition-all"></div>
        <div class="relative z-10 flex justify-between items-start">
            <div>
                <p class="text-slate-400 font-bold text-[11px] uppercase tracking-[0.2em] mb-2">Aylık Ziyaretçi</p>
                <h3 class="text-4xl font-black text-transparent bg-clip-text bg-gradient-to-r from-amber-400 to-yellow-300">14.2K</h3>
            </div>
            <div class="w-12 h-12 rounded-2xl bg-amber-500/10 border border-amber-500/20 flex items-center justify-center text-amber-400 shadow-[0_0_15px_rgba(245,158,11,0.3)]">
                <i class="fa-solid fa-chart-pie text-xl"></i>
            </div>
        </div>
    </div>
</div>

"@
    
    $content = $content.Remove($startIndex, $endIndex - $startIndex).Insert($startIndex, $newCards)
    [System.IO.File]::WriteAllText($path, $content, [System.Text.Encoding]::UTF8)
}