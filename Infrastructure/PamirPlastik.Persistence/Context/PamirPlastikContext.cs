using Microsoft.EntityFrameworkCore;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Persistence.Context
{
    public class PamirPlastikContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8JMCHUH\\SQLEXPRESS;initial Catalog=PamirPlastikDb;integrated Security=true;TrustServerCertificate=True;");
        }

        // Mevcut Tabloların
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutFeature> AboutFeatures { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        
        // EKSIK OLAN TABLOLAR (GERI EKLENDI)
        public DbSet<Color> Colors { get; set; }
        public DbSet<Fair> Fairs { get; set; }
        public DbSet<HomePageSetting> HomePageSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Kategori - Ürün İlişkisi (Bir kategorinin birçok ürünü olabilir)
            modelBuilder.Entity<Product>()
                .HasOne(x => x.Category)
                .WithMany(y => y.Products)
                .HasForeignKey(z => z.CategoryID);

            // Ürün - ÜrünGörseli İlişkisi (Bir ürünün birçok görseli olabilir)
            // Cascade: Ürün silindiğinde o ürüne ait galeri kayıtları da otomatik temizlenir.
            modelBuilder.Entity<ProductImage>()
                .HasOne(x => x.Product)
                .WithMany(y => y.ProductImages)
                .HasForeignKey(z => z.ProductID)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}