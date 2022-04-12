using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
   public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; }
        public int AltKategoriId { get; set; }
        public List<SepetDetay> sepetDetay { get; set; }
        public List<FaturaDetay> faturaDetay { get; set; }
        public AltKategori altKategori { get; set; }
    }
}
