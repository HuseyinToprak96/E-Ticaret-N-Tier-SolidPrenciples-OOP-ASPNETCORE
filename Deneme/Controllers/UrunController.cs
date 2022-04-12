using AutoMapper;
using CoreLayer.Dtos;
using CoreLayer.Interfaces;
using CoreLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme.Controllers
{
    public class UrunController : Controller
    {
        private readonly IService<Urun> _service;
        private readonly IMapper _mapper;
        public UrunController(IService<Urun> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IActionResult> UrunlerListesi()
        {
            var urunler = await _service.List() ;
            var urunlerDto = _mapper.Map<List<UrunDto>>(urunler);
          return View(urunlerDto);
        }
        public IActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UrunEkle(UrunDto urunDto)
        {
            var urun = _mapper.Map<Urun>(urunDto);
            await _service.Add(urun);
            return RedirectToAction("UrunListesi");
        }
        public async Task<IActionResult> UrunDetay(int id)
        {
            return View(await _service.Find(id));
        }
        public IActionResult UrunSil(int id)
        {
            _service.Delete(id);
            return RedirectToAction("UrunListesi");
        }
        public IActionResult UrunGuncelle(UrunDto urunDto)
        {
            var urun = _mapper.Map<Urun>(urunDto);
            _service.Update(urun);
            return RedirectToAction("UrunListesi");
        }
    }
}
