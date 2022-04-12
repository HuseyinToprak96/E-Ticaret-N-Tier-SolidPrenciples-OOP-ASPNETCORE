using AutoMapper;
using CoreLayer.Dtos;
using CoreLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IKategoriService _kategoriService;
       
        private readonly IMapper _mapper;
        public KategoriController(IKategoriService kategoriService, IMapper mapper)
        {
            _kategoriService = kategoriService;
            _mapper = mapper;
        }
        public IActionResult KategoriListesi()
        {
            var kategoriler = _kategoriService.List();
            var kategorilerDto = _mapper.Map<List<KategoriDto>>(kategoriler);
            return View(kategorilerDto);
        }
    }
}
