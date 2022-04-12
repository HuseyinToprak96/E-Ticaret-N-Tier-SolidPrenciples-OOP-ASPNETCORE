using CoreLayer.Interfaces;
using CoreLayer.Models;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
   public class UrunRepository:Repository<Urun>,IUrunRepository
    {
        private readonly Context __context;
        public UrunRepository(Context context):base(context)
        {
            __context = context;
        }
        public List<Urun> EnCokSatanlar()
        {
            return _context.Urunler.ToList();
        }
        public List<Urun> YeniGelenler()
        {
            return _context.Urunler.ToList();
        }
    }
}
