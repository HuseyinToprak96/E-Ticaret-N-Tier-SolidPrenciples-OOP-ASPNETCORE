using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
   public class SepetDetay
    {
        public int SepetDetayId { get; set; }
        public int UrunId { get; set; }
        public int SepetId { get; set; }
        public Sepet sepet { get; set; }

    }
}
