using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
   public class AltKategori
    {
        public int AltKategoriId { get; set; }
        public string AltKategoriAdi { get; set; }
        public int KategoriId { get; set; }
        public Kategori kategori { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}
