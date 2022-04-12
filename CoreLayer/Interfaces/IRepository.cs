using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Interfaces
{
   public interface IRepository<T> where T:class
    {
        Task AddAsync(T t);
        void Delete(int id);
        void Update(T t);
        Task<List<T>> ToListAsync();
        Task<T> FindAsync(int id);
    }
}
