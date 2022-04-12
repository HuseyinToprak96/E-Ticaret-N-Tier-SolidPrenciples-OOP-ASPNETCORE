using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos
{
   public class FaturaDto
    {
        public int FaturaId { get; set; }
        public int UyeId { get; set; }
        public decimal FaturaTutari { get; set; }
    }
}
