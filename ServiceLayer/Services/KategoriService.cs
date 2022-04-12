using AutoMapper;
using CoreLayer.Dtos;
using CoreLayer.Interfaces;
using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class KategoriService : Service<Kategori>, IKategoriService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Kategori> __repository;
        public KategoriService(IMapper mapper,IRepository<Kategori> repository,IUnitOfWork unitOfWork):base(repository,unitOfWork)
        {
            _mapper = mapper;
            __repository = repository;
        }

        public async Task<KategoriAltKategoriUrunDto> KategoriyeGoreAltKategorilerveUrunler(int id)
        {
            var kategoriAltKategoriUrunDto = _mapper.Map<KategoriAltKategoriUrunDto>(await _repository.FindAsync(id));
            return kategoriAltKategoriUrunDto;
        }
    }
}
