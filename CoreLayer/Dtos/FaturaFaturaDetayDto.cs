using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos
{
   public class FaturaFaturaDetayDto:FaturaDto
    {
        public List<FaturaDetayDto> faturaDetayDtos { get; set; }
    }
}
