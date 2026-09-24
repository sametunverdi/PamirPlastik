using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace FaviconMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Samet\.gemini\antigravity\brain\7c34d08b-5403-49e7-97f5-124b9b24c703\.user_uploaded\media_1790279436228.jpg";
            string destPath = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\wwwroot\images\favicon-square.png";
            
            try
            {
                using (var image = Image.Load<Rgba32>(sourcePath))
                {
                    int width = image.Width;
                    int height = image.Height;
                    
                    int leftX = -1;
                    int rightX = -1;
                    
                    for (int x = 0; x < width; x++)
                    {
                        bool colHasColor = false;
                        for (int y = 0; y < height; y++)
                        {
                            var p = image[x, y];
                            if (p.R < 240 || p.G < 240 || p.B < 240)
                            {
                                colHasColor = true;
                                break;
                            }
                        }
                        
                        if (colHasColor && leftX == -1) leftX = x;
                        else if (!colHasColor && leftX != -1 && rightX == -1)
                        {
                            rightX = x;
                            break;
                        }
                    }
                    
                    if (rightX == -1) rightX = width;
                    
                    int topY = height;
                    int bottomY = 0;
                    
                    for (int x = leftX; x < rightX; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            var p = image[x, y];
                            if (p.R < 240 || p.G < 240 || p.B < 240)
                            {
                                if (y < topY) topY = y;
                                if (y > bottomY) bottomY = y;
                            }
                        }
                    }
                    
                    int symWidth = rightX - leftX;
                    int symHeight = bottomY - topY;
                    int size = Math.Max(symWidth, symHeight);
                    int paddedSize = (int)(size * 1.15); // 15% padding
                    
                    image.Mutate(m => {
                        m.Crop(new Rectangle(leftX, topY, symWidth, symHeight));
                        m.Resize(new ResizeOptions
                        {
                            Mode = ResizeMode.Pad,
                            Size = new Size(paddedSize, paddedSize),
                            PadColor = Color.White
                        });
                    });
                    
                    image.Save(destPath);
                    Console.WriteLine("FAVICON_SURGICAL_CROP_BASARILI");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA: " + ex.Message);
            }
        }
    }
}