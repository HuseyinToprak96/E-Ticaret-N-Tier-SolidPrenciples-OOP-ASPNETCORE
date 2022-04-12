using CoreLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class Service<T> : IService<T> where T:class
    {
        protected readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task Add(T t)
        {
           await _repository.AddAsync(t);
           await _unitOfWork.KaydetAsync();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _unitOfWork.Kaydet();
        }

        public async Task<T> Find(int id)
        {
            return await _repository.FindAsync(id);
        }

        public async Task<List<T>> List()
        {
            return await _repository.ToListAsync();
        }

        public void Update(T t)
        {
            _repository.Update(t);
            _unitOfWork.Kaydet();
        }
    }
}
