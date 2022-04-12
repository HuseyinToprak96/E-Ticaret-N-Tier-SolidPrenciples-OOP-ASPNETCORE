using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
   public class Uye
    {
        public int UyeId { get; set; }
        public string Resim { get; set; }
        public string UyeAdi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public Sepet sepet { get; set; }
        public Fatura fatura { get; set; }
    }
}
