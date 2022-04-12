using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos
{
   public class UrunDto
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; }
    }
}
