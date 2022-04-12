using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
   public class Sepet
    {
        public int SepetId { get; set; }
        public int UyeId { get; set; }
        public List<SepetDetay> sepetDetay { get; set; }
        public Uye uye { get; set; }
    }
}
