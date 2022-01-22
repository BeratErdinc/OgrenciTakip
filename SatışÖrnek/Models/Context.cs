using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatışÖrnek.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S9UV1QU\\BERAT; database=Ogrenci_not; integrated security=true;");
        }
        public DbSet<Ogrenci> Ogrencıs { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Kulup> Kulup { get; set; }
        public DbSet<Notlar> Notlar { get; set; }
    }
}
