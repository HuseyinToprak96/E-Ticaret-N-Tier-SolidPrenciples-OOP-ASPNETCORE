using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
   public class FaturaDetay
    {
        public int FaturaDetayId { get; set; }
        public int UrunId { get; set; }
        public int FaturaId { get; set; }
        public Urun urun { get; set; }
        public Fatura fatura { get; set; }
    }
}
