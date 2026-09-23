using System;
using System.IO;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string dir = @"c:\Users\Samet\Desktop\Project\PamirPlastik\Frontends\PamirPlastik.WebUI\wwwroot\images\products";
        string connStr = @"Server=DESKTOP-8JMCHUH\SQLEXPRESS;Database=PamirPlastikDb;Integrated Security=true;TrustServerCertificate=True;";
        
        var files = Directory.GetFiles(dir, "*.jpg");
        int counter = 1;
        
        using (var conn = new SqlConnection(connStr))
        {
            conn.Open();
            foreach(var file in files)
            {
                string oldName = Path.GetFileName(file);
                string newName = $"product_img_{counter}.jpg";
                string newPath = Path.Combine(dir, newName);
                
                // Rename file
                File.Move(file, newPath);
                
                string oldDbUrl = "/images/products/" + oldName;
                string newDbUrl = "/images/products/" + newName;
                
                // Update Products
                using (var cmd = new SqlCommand("UPDATE Products SET MainImageUrl = @new WHERE MainImageUrl = @old", conn))
                {
                    cmd.Parameters.AddWithValue("@new", newDbUrl);
                    cmd.Parameters.AddWithValue("@old", oldDbUrl);
                    cmd.ExecuteNonQuery();
                }
                
                // Update ProductImages
                using (var cmd = new SqlCommand("UPDATE ProductImages SET ImageUrl = @new WHERE ImageUrl = @old", conn))
                {
                    cmd.Parameters.AddWithValue("@new", newDbUrl);
                    cmd.Parameters.AddWithValue("@old", oldDbUrl);
                    cmd.ExecuteNonQuery();
                }
                
                counter++;
            }
        }
        Console.WriteLine("All images renamed and database updated to ASCII safe names!");
    }
}
