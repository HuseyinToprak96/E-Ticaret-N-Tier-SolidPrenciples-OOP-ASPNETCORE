using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
   public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<AltKategori> altKategoriler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<FaturaDetay> FaturaDetaylari { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }
        public DbSet<SepetDetay> SepetDetay { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
