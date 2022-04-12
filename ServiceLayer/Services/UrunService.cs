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
    public class UrunService : Service<Urun>, IUrunService
    {
        private readonly IUrunRepository _urunRepository;
        private readonly IMapper _mapper;
        public UrunService(IUrunRepository repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork)
        {
            _urunRepository = repository;
            _mapper = mapper;
        }
        public List<UrunDto> EnCokSatanlar()
        {
           var urunler= _urunRepository.EnCokSatanlar();
           var urunDto= _mapper.Map<List<UrunDto>>(urunler);
            return  urunDto;
        }

        public List<UrunDto> YeniGelenler()
        {
            var urunler = _urunRepository.YeniGelenler();
            var urunDto = _mapper.Map<List<UrunDto>>(urunler);
            return urunDto;
        }
    }
}
