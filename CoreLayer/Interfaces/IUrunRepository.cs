using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Interfaces
{
   public interface IUrunRepository:IRepository<Urun>
    {
        List<Urun> EnCokSatanlar();
        List<Urun> YeniGelenler();
    }
}
