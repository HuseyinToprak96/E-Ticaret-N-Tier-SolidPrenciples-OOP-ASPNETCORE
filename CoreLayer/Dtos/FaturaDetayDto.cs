﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos
{
   public class FaturaDetayDto
    {
        public int FaturaDetayId { get; set; }
        public int UrunId { get; set; }
        public int FaturaId { get; set; }
    }
}
