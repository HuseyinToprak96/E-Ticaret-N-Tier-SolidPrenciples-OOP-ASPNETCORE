using CoreLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AJAX_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AskiController : ControllerBase
    {
      private readonly  IUrunService _urunService;
      private readonly IKategoriService _kategoriService;

        public AskiController(IUrunService urunService, IKategoriService kategoriService)
        {
            _urunService = urunService;
            _kategoriService = kategoriService;
        }


    }
}
