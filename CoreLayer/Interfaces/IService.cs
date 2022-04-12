using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Interfaces
{
   public interface IService<T> where T:class
    {
        Task Add(T t);
        void Delete(int id);
        void Update(T t);
        Task<List<T>> List();
        Task<T> Find(int id);
    }
}
