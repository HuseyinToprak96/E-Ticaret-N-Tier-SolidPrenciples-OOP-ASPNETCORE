using CoreLayer.Interfaces;
using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Context _context;
        private readonly DbSet<T> _dbSet;
        public Repository(Context context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task AddAsync(T t)
        {
           await _dbSet.AddAsync(t);
        }

        public void Delete(int id)
        {
          var result=  _dbSet.Find(id);
            _dbSet.Remove(result);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> ToListAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
