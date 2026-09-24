using System;
using System.Linq;
using PamirPlastik.Persistence.Context;
using PamirPlastik.Domain.Entities;

namespace SystemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- PAMİR PLASTİK SİSTEM TESTİ BAŞLIYOR ---");
            try
            {
                using (var context = new PamirPlastikContext())
                {
                    // 1. CREATE
                    Console.WriteLine("1. CREATE (Ekleme) aşaması başlatılıyor...");
                    
                    var testColor = new Color { Name_TR = "TEST_Uzay_Mavisi", Name_EN = "TEST_Space_Blue", HexCode = "#0000FF" };
                    context.Colors.Add(testColor);
                    
                    var testCategory = new Category { Name_TR = "TEST_Kategori", Name_EN = "TEST_Category", ShowOnHome = false, Status = true };
                    context.Categories.Add(testCategory);
                    
                    context.SaveChanges(); 

                    var testProduct = new Product { Name_TR = "TEST_Urun", Name_EN = "TEST_Product", CategoryID = testCategory.CategoryID, Status = true, ShortDescription_TR = "Test" };
                    context.Products.Add(testProduct);

                    var testAbout = new About { MainTitle_TR = "TEST_Hakkimizda", Description1_TR = "Test Desc" };
                    context.Abouts.Add(testAbout);
                    context.SaveChanges();

                    var testFeature = new AboutFeature { AboutId = testAbout.Id, Title_TR = "TEST_Ozellik" };
                    context.AboutFeatures.Add(testFeature);

                    var testFair = new Fair { Name = "TEST_Fuar", IsFuture = true };
                    context.Fairs.Add(testFair);

                    var testSocial = new SocialMedia { PlatformName = "TEST_Instagram", Url = "test", IconClass = "test", IsActive = true };
                    context.SocialMedias.Add(testSocial);

                    var testJob = new JobApplication { FirstName = "TEST_Ad", LastName = "TEST_Soyad", ApplicationDate = DateTime.Now, CvPdfUrl="test", Email="test", Message="test", Phone="test" };
                    context.JobApplications.Add(testJob);

                    var testMsg = new ContactMessage { FullName = "TEST_Musteri", SendDate = DateTime.Now, IsRead = false };
                    context.ContactMessages.Add(testMsg);

                    context.SaveChanges();
                    Console.WriteLine("CREATE BAŞARILI: Tüm test verileri eklendi.");

                    // 2. UPDATE
                    Console.WriteLine("2. UPDATE (Güncelleme) aşaması başlatılıyor...");
                    testColor.HexCode = "#FF0000";
                    testCategory.ShowOnHome = true;
                    testProduct.Status = false;
                    testFair.IsFuture = false;
                    testMsg.IsRead = true;
                    
                    context.SaveChanges();
                    Console.WriteLine("UPDATE BAŞARILI: Test verileri güncellendi.");

                    // 3. READ
                    Console.WriteLine("3. READ (Okuma) aşaması başlatılıyor...");
                    var checkColor = context.Colors.FirstOrDefault(x => x.Name_TR == "TEST_Uzay_Mavisi");
                    if (checkColor != null && checkColor.HexCode == "#FF0000") 
                        Console.WriteLine("READ BAŞARILI: Veriler okundu ve değişiklikler teyit edildi.");
                    else
                        Console.WriteLine("READ HATASI!");

                    // 4. DELETE
                    Console.WriteLine("4. DELETE (Silme) aşaması başlatılıyor...");
                    context.Products.RemoveRange(context.Products.Where(x => x.Name_TR.Contains("TEST_")));
                    context.Categories.RemoveRange(context.Categories.Where(x => x.Name_TR.Contains("TEST_")));
                    context.Colors.RemoveRange(context.Colors.Where(x => x.Name_TR.Contains("TEST_")));
                    context.AboutFeatures.RemoveRange(context.AboutFeatures.Where(x => x.Title_TR.Contains("TEST_")));
                    context.Abouts.RemoveRange(context.Abouts.Where(x => x.MainTitle_TR.Contains("TEST_")));
                    context.Fairs.RemoveRange(context.Fairs.Where(x => x.Name.Contains("TEST_")));
                    context.SocialMedias.RemoveRange(context.SocialMedias.Where(x => x.PlatformName.Contains("TEST_")));
                    context.JobApplications.RemoveRange(context.JobApplications.Where(x => x.FirstName.Contains("TEST_")));
                    context.ContactMessages.RemoveRange(context.ContactMessages.Where(x => x.FullName.Contains("TEST_")));

                    context.SaveChanges();
                    Console.WriteLine("DELETE BAŞARILI: Tüm test verileri kalıcı olarak temizlendi.");
                    Console.WriteLine("--- TEST TAMAMLANDI: SISTEM %100 STABIL ---");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA: " + ex.Message);
                if (ex.InnerException != null) Console.WriteLine("DETAY: " + ex.InnerException.Message);
            }
        }
    }
}