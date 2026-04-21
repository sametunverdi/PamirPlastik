using Microsoft.EntityFrameworkCore;
using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Persistence.Context
{
    public class PamirPlastikContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=DESKTOP-8JMCHUH\\SQLEXPRESS;initial Catalog=PamirPlastikDb;integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutFeature> AboutFeatures { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }


    }
}
