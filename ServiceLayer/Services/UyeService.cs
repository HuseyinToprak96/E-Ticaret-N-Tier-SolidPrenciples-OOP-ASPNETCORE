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
    public class UyeService : Service<Uye>, IUyeService
    {
        private readonly IUyeRepository __repository;
        public UyeService(IUyeRepository repository,IUnitOfWork unitOfWork):base(repository,unitOfWork)
        {
            __repository = repository;
        }

        public int UserLogin(LoginDto loginDto)
        {
          return  __repository.UserLogin(loginDto);
        }
    }
}
