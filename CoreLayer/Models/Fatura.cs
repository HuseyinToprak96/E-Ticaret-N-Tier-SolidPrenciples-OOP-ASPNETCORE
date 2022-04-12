using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
   public class Fatura
    {
        public int FaturaId { get; set; }
        public int UyeId { get; set; }
        public decimal FaturaTutari { get; set; }
        public Uye uye { get; set; }
        public List<FaturaDetay> faturaDetay { get; set; }

    }
}
