using System;
using System.IO;
using System.Text;

public class ContactFixer
{
    public static void Fix()
    {
        string path = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\Views\Contact\Index.cshtml";
        // Use UTF8 encoding to read
        string content = File.ReadAllText(path, Encoding.UTF8);
        
        // 1. Replace Samet
        content = content.Replace("Samet ...", "Adınız Soyadınız...");
        
        // 2. Button replacement
        string oldButton = @"<button type=""submit"" class=""group w-full py-6 bg-[#0f172a] text-white rounded-2xl font-black text-[11px] tracking-[0.3em] uppercase shadow-lg hover:bg-pamir-brand transition-all flex items-center justify-center gap-3 active:scale-[0.98]"">
                            <span>MESAJI GÖNDER</span>
                            <i class=""fa-solid fa-paper-plane transform group-hover:translate-x-1 group-hover:-translate-y-1 transition-transform text-[#ffda44]""></i>
                        </button>";
                        
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
                        
        content = content.Replace(oldButton, newButton);
        
        // 3. Modal and Script at the end
        string modalHtml = @"
<!-- Job Application Modal -->
<div id=""jobApplicationModal"" class=""fixed inset-0 z-[100] hidden"">
    <div class=""absolute inset-0 bg-black/60 backdrop-blur-sm"" onclick=""document.getElementById('jobApplicationModal').classList.add('hidden')""></div>
    <div class=""absolute top-1/2 left-1/2 -translate-x-1/2 -translate-y-1/2 w-full max-w-2xl bg-white rounded-[2rem] shadow-2xl p-8 max-h-[90vh] overflow-y-auto"">
        <div class=""flex justify-between items-center mb-6"">
            <div>
                <h3 class=""text-2xl font-black text-[#0f172a] uppercase tracking-tighter"">İş Başvurusu</h3>
                <p class=""text-sm text-gray-500 font-medium mt-1"">Ekibimize katılmak için aşağıdaki formu doldurun.</p>
            </div>
            <button onclick=""document.getElementById('jobApplicationModal').classList.add('hidden')"" class=""w-10 h-10 rounded-xl bg-gray-100 text-gray-500 flex items-center justify-center hover:bg-red-50 hover:text-red-500 transition-colors"">
                <i class=""fa-solid fa-xmark""></i>
            </button>
        </div>

        <form action=""/JobApplication/SubmitApplication"" method=""post"" enctype=""multipart/form-data"" class=""space-y-5"">
            <div class=""grid grid-cols-1 md:grid-cols-2 gap-5"">
                <div class=""space-y-1.5"">
                    <label class=""text-[10px] font-black text-gray-400 uppercase tracking-widest ml-4"">Adınız</label>
                    <input type=""text"" name=""FirstName"" class=""w-full bg-gray-50 border border-gray-100 rounded-2xl py-3 px-5 text-sm text-[#0f172a] focus:border-pamir-brand focus:outline-none transition-all"" required>
                </div>
                <div class=""space-y-1.5"">
                    <label class=""text-[10px] font-black text-gray-400 uppercase tracking-widest ml-4"">Soyadınız</label>
                    <input type=""text"" name=""LastName"" class=""w-full bg-gray-50 border border-gray-100 rounded-2xl py-3 px-5 text-sm text-[#0f172a] focus:border-pamir-brand focus:outline-none transition-all"" required>
                </div>
            </div>

            <div class=""grid grid-cols-1 md:grid-cols-2 gap-5"">
                <div class=""space-y-1.5"">
                    <label class=""text-[10px] font-black text-gray-400 uppercase tracking-widest ml-4"">E-Posta</label>
                    <input type=""email"" name=""Email"" class=""w-full bg-gray-50 border border-gray-100 rounded-2xl py-3 px-5 text-sm text-[#0f172a] focus:border-pamir-brand focus:outline-none transition-all"" required>
                </div>
                <div class=""space-y-1.5"">
                    <label class=""text-[10px] font-black text-gray-400 uppercase tracking-widest ml-4"">Telefon</label>
                    <input type=""tel"" name=""Phone"" class=""w-full bg-gray-50 border border-gray-100 rounded-2xl py-3 px-5 text-sm text-[#0f172a] focus:border-pamir-brand focus:outline-none transition-all"" required>
                </div>
            </div>

            <div class=""space-y-1.5"">
                <label class=""text-[10px] font-black text-gray-400 uppercase tracking-widest ml-4"">Ön Yazı / Mesajınız</label>
                <textarea name=""Message"" rows=""3"" class=""w-full bg-gray-50 border border-gray-100 rounded-2xl py-3 px-5 text-sm text-[#0f172a] focus:border-pamir-brand focus:outline-none transition-all resize-none"" placeholder=""Kısaca kendinizden bahsedin...""></textarea>
            </div>

            <div class=""space-y-1.5"">
                <label class=""text-[10px] font-black text-gray-400 uppercase tracking-widest ml-4"">Özgeçmiş (CV) Yükle <span class=""text-red-500"">* Sadece PDF</span></label>
                <input type=""file"" name=""CvFile"" accept="".pdf"" class=""w-full bg-white border-2 border-dashed border-gray-200 rounded-2xl py-4 px-5 text-sm text-gray-500 focus:border-pamir-brand transition-all cursor-pointer"" required>
            </div>

            <button type=""submit"" class=""w-full py-4 bg-pamir-brand text-white rounded-2xl font-black text-[11px] tracking-[0.3em] uppercase hover:bg-[#0f172a] transition-colors mt-2 shadow-lg shadow-pamir-brand/30"">
                BAŞVURUYU TAMAMLA
            </button>
        </form>
    </div>
</div>

<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script>
    @if (TempData[""SuccessMessage""] != null)
    {
        <text>
        Swal.fire({
            title: 'Başarılı!',
            text: '@TempData[""SuccessMessage""]',
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
            text: '@TempData[""ErrorMessage""]',
            icon: 'error',
            confirmButtonText: 'Tamam',
            confirmButtonColor: '#ef4444'
        });
        </text>
    }
</script>
";
        
        content = content + Environment.NewLine + modalHtml;
        File.WriteAllText(path, content, new UTF8Encoding(false)); // Save cleanly as UTF8 without BOM
    }
}
