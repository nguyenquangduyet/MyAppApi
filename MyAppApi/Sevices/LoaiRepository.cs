﻿using MyAppApi.Data;
using MyAppApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyAppApi.Sevices
{
    public class LoaiRepository : ILoaiReposotory
    {
        private readonly MyDbContext _context;

        public LoaiRepository(MyDbContext context)
        {
            _context = context;
        }
        public LoaiVN Add(LoaiModel loai)
        {
            var _loai = new Loai
            {
                TenLoai = loai.TenLoai
            };
            _context.Add(_loai);
            _context.SaveChanges();

            return new LoaiVN
            {
                MaLoai = _loai.MaLoai,
                TenLoai = _loai.TenLoai
            };
        }

        public void Delete(int id)
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.MaLoai == id);
                if(loai!= null)
            {
                _context.Remove(loai);
                _context.SaveChanges();
            }
        }

        public List<LoaiVN> GetAll()
        {
            var loais = _context.Loais.Select(lo => new LoaiVN
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai
            });
            return loais.ToList();
        }

        public LoaiVN GetById(int id)
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.MaLoai == id);
            if(loai == null)
            {
                return new LoaiVN
                {
                    MaLoai = loai.MaLoai,
                    TenLoai = loai.TenLoai
                };
            }
            return null;
        }

        public void Upadate(LoaiVN loai)
        {
            var _loai = _context.Loais.SingleOrDefault(lo => lo.MaLoai == loai.MaLoai);
            loai.TenLoai = loai.TenLoai;
            _context.SaveChanges();
        }
    }
}