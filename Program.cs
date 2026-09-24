using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FaviconMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\wwwroot\images\logo-blue.png";
            string destPath = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\wwwroot\images\favicon-square.png";
            
            try
            {
                using (var image = Image.Load(sourcePath))
                {
                    // Kare yapmak icin yuksekligi baz al
                    int size = image.Height;
                    if (size > image.Width) size = image.Width;
                    
                    // Soldan tam bir kare kes (Sembol kismi)
                    image.Mutate(x => x.Crop(new Rectangle(0, 0, size, size)));
                    image.Save(destPath);
                    Console.WriteLine("FAVICON_BASARILI");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA: " + ex.Message);
            }
        }
    }
}