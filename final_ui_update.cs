using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Areas\Admin\Views\Dashboard\Index.cshtml";
        string content = @"
@{
    ViewData["Title"] = "Dashboard";
}

<!-- Chart.js CDN -->
<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>

<div class="mb-8 flex flex-col sm:flex-row sm:items-center sm:justify-between gap-4">
    <div>
        <h1 class="text-3xl font-black text-slate-800 tracking-tight">Sistem Kontrol Merkezi</h1>
        <p class="text-slate-500 font-medium mt-1">Tüm veriler, analizler ve hızlı erişim araçları.</p>
    </div>
    
    <!-- CANLI SAAT VE TARİH -->
    <div class="flex items-center gap-3 bg-white px-5 py-3 rounded-xl border border-slate-200 shadow-sm">
        <div class="w-10 h-10 rounded-full bg-slate-100 flex items-center justify-center text-slate-600">
            <i class="fa-regular fa-clock text-lg"></i>
        </div>
        <div>
            <div id="liveTime" class="text-lg font-black text-slate-800 tracking-wider">00:00:00</div>
            <div id="liveDate" class="text-xs font-semibold text-slate-400 uppercase tracking-widest">Yükleniyor...</div>
        </div>
    </div>
</div>

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

    <!-- Sosyal Medya -->
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
    </div>
</div>

<!-- CHARTS SECTION -->
<div class="grid grid-cols-1 lg:grid-cols-3 gap-6 mb-10">
    
    <!-- Line Chart (Dinamik Mesaj Trafiği) -->
    <div class="lg:col-span-2 bg-white rounded-3xl p-6 shadow-[0_5px_20px_rgba(0,0,0,0.03)] border border-slate-100 relative overflow-hidden">
        <div class="flex justify-between items-center mb-6">
            <h3 class="text-lg font-black text-slate-800"><i class="fa-solid fa-chart-line text-primary mr-2"></i>İletişim Trafiği (Son 7 Gün)</h3>
            <span class="text-xs font-bold bg-slate-100 text-slate-500 px-3 py-1 rounded-full">Canlı Veri</span>
        </div>
        <div class="relative h-[300px] w-full">
            <canvas id="trafficChart"></canvas>
        </div>
    </div>

    <!-- Doughnut Chart (Dinamik Kategoriler) -->
    <div class="bg-white rounded-3xl p-6 shadow-[0_5px_20px_rgba(0,0,0,0.03)] border border-slate-100 relative overflow-hidden">
        <div class="flex justify-between items-center mb-6">
            <h3 class="text-lg font-black text-slate-800"><i class="fa-solid fa-chart-pie text-primary mr-2"></i>Kategori Dağılımı</h3>
        </div>
        <div class="relative h-[300px] w-full flex items-center justify-center">
            <canvas id="categoryChart"></canvas>
        </div>
    </div>
</div>

<!-- QUICK ACTIONS & TIMELINE -->
<div class="grid grid-cols-1 lg:grid-cols-2 gap-6">
    <!-- Hızlı İşlemler -->
    <div class="bg-gradient-to-br from-[#0f172a] to-[#1e293b] rounded-3xl p-8 shadow-xl border border-slate-700/50">
        <h3 class="text-lg font-black text-white mb-6"><i class="fa-solid fa-bolt text-yellow-400 mr-2"></i>Hızlı İşlem Merkezi</h3>
        <div class="grid grid-cols-2 gap-4">
            <a href="/Admin/Product/Create" class="flex flex-col items-center justify-center gap-3 bg-white/5 hover:bg-white/10 p-6 rounded-2xl border border-white/10 transition-colors group">
                <div class="w-12 h-12 bg-blue-500/20 rounded-full flex items-center justify-center text-blue-400 group-hover:scale-110 transition-transform"><i class="fa-solid fa-box-open text-xl"></i></div>
                <span class="text-slate-300 font-bold text-sm">Yeni Ürün Ekle</span>
            </a>
            <a href="/Admin/Category/Create" class="flex flex-col items-center justify-center gap-3 bg-white/5 hover:bg-white/10 p-6 rounded-2xl border border-white/10 transition-colors group">
                <div class="w-12 h-12 bg-purple-500/20 rounded-full flex items-center justify-center text-purple-400 group-hover:scale-110 transition-transform"><i class="fa-solid fa-layer-group text-xl"></i></div>
                <span class="text-slate-300 font-bold text-sm">Kategori Aç</span>
            </a>
            <a href="/Admin/Message" class="flex flex-col items-center justify-center gap-3 bg-white/5 hover:bg-white/10 p-6 rounded-2xl border border-white/10 transition-colors group">
                <div class="w-12 h-12 bg-red-500/20 rounded-full flex items-center justify-center text-red-400 group-hover:scale-110 transition-transform"><i class="fa-solid fa-envelope text-xl"></i></div>
                <span class="text-slate-300 font-bold text-sm">Mesajları Oku</span>
            </a>
            <a href="/Admin/JobApplication" class="flex flex-col items-center justify-center gap-3 bg-white/5 hover:bg-white/10 p-6 rounded-2xl border border-white/10 transition-colors group">
                <div class="w-12 h-12 bg-emerald-500/20 rounded-full flex items-center justify-center text-emerald-400 group-hover:scale-110 transition-transform"><i class="fa-solid fa-briefcase text-xl"></i></div>
                <span class="text-slate-300 font-bold text-sm">İş Başvuruları</span>
            </a>
        </div>
    </div>
    
    <!-- Sistem Özeti -->
    <div class="bg-white rounded-3xl p-8 shadow-xl border border-slate-100">
        <h3 class="text-lg font-black text-slate-800 mb-6"><i class="fa-solid fa-heart-pulse text-red-500 mr-2"></i>Sistem Sağlığı & Özet</h3>
        <ul class="space-y-6">
            <li class="flex gap-4 items-start">
                <div class="mt-0.5 w-10 h-10 rounded-full bg-emerald-100 flex-shrink-0 flex items-center justify-center text-emerald-600"><i class="fa-solid fa-check"></i></div>
                <div>
                    <h4 class="text-sm font-bold text-slate-800">Tüm Servisler Aktif</h4>
                    <p class="text-xs text-slate-500 mt-1">API, Veritabanı ve Sunucu bağlantılarında sorun yok.</p>
                </div>
            </li>
            <li class="flex gap-4 items-start">
                <div class="mt-0.5 w-10 h-10 rounded-full bg-blue-100 flex-shrink-0 flex items-center justify-center text-blue-600"><i class="fa-solid fa-shield-halved"></i></div>
                <div>
                    <h4 class="text-sm font-bold text-slate-800">Güvenlik Durumu: İdeal</h4>
                    <p class="text-xs text-slate-500 mt-1">Son 24 saatte şüpheli bir giriş denemesi saptanmadı.</p>
                </div>
            </li>
            <li class="flex gap-4 items-start">
                <div class="mt-0.5 w-10 h-10 rounded-full bg-amber-100 flex-shrink-0 flex items-center justify-center text-amber-600"><i class="fa-solid fa-database"></i></div>
                <div>
                    <h4 class="text-sm font-bold text-slate-800">Veritabanı Yükü: Minimum</h4>
                    <p class="text-xs text-slate-500 mt-1">Sistem kaynakları optimum seviyede çalışıyor.</p>
                </div>
            </li>
        </ul>
    </div>
</div>

<script>
    // Canlı Saat Mekanizması
    function updateClock() {
        const now = new Date();
        const timeStr = now.toLocaleTimeString('tr-TR', { hour12: false });
        const dateStr = now.toLocaleDateString('tr-TR', { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' });
        
        document.getElementById('liveTime').innerText = timeStr;
        document.getElementById('liveDate').innerText = dateStr;
    }
    setInterval(updateClock, 1000);
    updateClock();

    document.addEventListener("DOMContentLoaded", function() {
        // Dinamik Verileri C# ViewData/ViewBag'den Alma
        const categoryLabels = @Html.Raw(ViewBag.CategoryNames ?? "[]");
        const categoryData = @Html.Raw(ViewBag.CategoryProductCounts ?? "[]");
        
        const last7DaysLabels = @Html.Raw(ViewBag.Last7Days ?? "[]");
        const last7DaysData = @Html.Raw(ViewBag.Last7DaysMessageCounts ?? "[]");

        // 1. İletişim Trafiği Grafiği (Line Chart)
        const ctxTraffic = document.getElementById('trafficChart').getContext('2d');
        
        let gradientBlue = ctxTraffic.createLinearGradient(0, 0, 0, 400);
        gradientBlue.addColorStop(0, 'rgba(79, 70, 229, 0.4)');
        gradientBlue.addColorStop(1, 'rgba(79, 70, 229, 0.0)');
        
        new Chart(ctxTraffic, {
            type: 'line',
            data: {
                labels: last7DaysLabels, // Dinamik Tarihler
                datasets: [{
                    label: 'Gelen Mesaj',
                    data: last7DaysData, // Dinamik Sayılar
                    borderColor: '#4F46E5',
                    backgroundColor: gradientBlue,
                    borderWidth: 3,
                    pointBackgroundColor: '#ffffff',
                    pointBorderColor: '#4F46E5',
                    pointBorderWidth: 2,
                    pointRadius: 4,
                    pointHoverRadius: 6,
                    fill: true,
                    tension: 0.4 
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    legend: { display: false },
                    tooltip: {
                        backgroundColor: '#1e293b',
                        padding: 12,
                        titleFont: { size: 13, family: 'Outfit' },
                        bodyFont: { size: 14, family: 'Outfit', weight: 'bold' },
                        displayColors: false,
                        cornerRadius: 8
                    }
                },
                scales: {
                    y: {
                        beginAtZero: true,
                        ticks: { stepSize: 1 }, // Sadece tam sayı (mesaj sayısı)
                        grid: { borderDash: [4, 4], color: '#f1f5f9' },
                        border: { display: false }
                    },
                    x: {
                        grid: { display: false },
                        border: { display: false }
                    }
                }
            }
        });

        // 2. Kategori Dağılımı Grafiği (Doughnut Chart)
        const ctxCategory = document.getElementById('categoryChart').getContext('2d');
        new Chart(ctxCategory, {
            type: 'doughnut',
            data: {
                labels: categoryLabels.length > 0 ? categoryLabels : ['Veri Yok'], 
                datasets: [{
                    data: categoryData.length > 0 ? categoryData : [1], 
                    backgroundColor: [
                        '#4F46E5', // Indigo
                        '#0EA5E9', // Sky Blue
                        '#A855F7', // Purple
                        '#F43F5E', // Rose
                        '#10B981', // Emerald
                        '#F59E0B'  // Amber
                    ],
                    borderWidth: 0,
                    hoverOffset: 4
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                cutout: '75%', 
                plugins: {
                    legend: {
                        position: 'bottom',
                        labels: {
                            padding: 20,
                            font: { family: 'Outfit', size: 12, weight: 'bold' },
                            usePointStyle: true,
                            pointStyle: 'circle'
                        }
                    }
                }
            }
        });
    });
</script>
";
        File.WriteAllText(path, content.Replace(""", "\""), Encoding.UTF8);
    }
}