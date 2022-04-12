using AutoMapper;
using CoreLayer.Dtos;
using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapper
{
   public class MyProfile:Profile
    {
        public MyProfile()
        {
            CreateMap<Uye, UyeDto>().ReverseMap();
            CreateMap<Uye, UyeFaturaDto>().ForMember(x => x.faturaDto, src => src.MapFrom(x => x.fatura)).ReverseMap();
            CreateMap<Urun, UrunDto>().ReverseMap();
            CreateMap<Kategori, KategoriDto>().ReverseMap();
            CreateMap<AltKategori, AltKategoriDto>().ReverseMap();
            CreateMap<AltKategori, AltKategoriUrunDto>().ForMember(x => x.urunlerDto, src => src.MapFrom(x => x.Urunler)).ReverseMap();
            CreateMap<Kategori, KategoriAltKategoriUrunDto>().ForMember(x => x.altKategoriUrunDto, src => src.MapFrom(x => x.AltKategoriler)).ReverseMap();
            CreateMap<Sepet, SepetDto>().ReverseMap();
            CreateMap<SepetDetay, SepetDetayDto>().ReverseMap();
            CreateMap<Sepet, SepetSepetDetayDto>().ForMember(x => x.sepetDetayDto, src => src.MapFrom(x => x.sepetDetay)).ReverseMap();
            CreateMap<KategoriAltKategoriDto, KategoriAltKategoriUrunDto>().ForMember(x => x.altKategoriUrunDto, src => src.MapFrom(x => x.altKategoriUrunDto)).ReverseMap();
            CreateMap<Sepet, SepetDto>().ReverseMap();
            CreateMap<SepetDetay, SepetDetayDto>().ReverseMap();
            CreateMap<Fatura, FaturaDto>().ReverseMap();
            CreateMap<FaturaDetay, FaturaDetayDto>().ReverseMap();
            CreateMap<FaturaDetay, FaturaDetayUrunDto>().ForMember(x => x.urunDtos, src => src.MapFrom(x => x.urun)).ReverseMap();
            CreateMap<FaturaFaturaDetayDto, FaturaFaturaDetayUrunDto>().ForMember(x => x.faturaDetayUrunDto, src => src.MapFrom(x => x.faturaDetayDtos)).ReverseMap();
        }

    }
}
