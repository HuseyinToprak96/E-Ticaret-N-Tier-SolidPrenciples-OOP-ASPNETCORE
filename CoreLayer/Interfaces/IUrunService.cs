using CoreLayer.Dtos;
using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Interfaces
{
   public interface IUrunService:IService<Urun>
    {
        List<UrunDto> EnCokSatanlar();
        List<UrunDto> YeniGelenler();
    }
}
