using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
   public class Kategori 
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public List<AltKategori> AltKategoriler { get; set; }
    }
}
