using CoreLayer.Interfaces;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
        }
        public void Kaydet()
        {
            _context.SaveChanges();
        }

        public async Task KaydetAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
