using CoreLayer.Dtos;
using CoreLayer.Interfaces;
using CoreLayer.Models;
using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class UyeRepository : Repository<Uye>, IUyeRepository
    {
        private readonly Context __context;
        private readonly DbSet<Uye> _dbSet;

        public UyeRepository(Context context):base(context)
        {
            __context = context;
            _dbSet = context.Uyeler;

        }

        public int UserLogin(LoginDto loginDto)
        {
           var uye= _dbSet.Where(x => x.Email == loginDto.Email && x.Sifre == loginDto.Sifre).SingleOrDefault();
            return uye.UyeId;
        }
    }
}
