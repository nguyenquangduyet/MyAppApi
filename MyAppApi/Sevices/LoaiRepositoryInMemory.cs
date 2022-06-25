using MyAppApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyAppApi.Sevices
{
    public class LoaiRepositoryInMemory : ILoaiRepository
    {
        static List<LoaiVN> loais = new List<LoaiVN>
            {
                new LoaiVN{MaLoai =1, TenLoai = "tivi"},
                new LoaiVN{MaLoai =2, TenLoai = "dioen thoai"},
                new LoaiVN{MaLoai =3, TenLoai = "Laptop"},
                new LoaiVN{MaLoai =4, TenLoai = "thuoc"}
            };
        public LoaiVN Add(LoaiModel loai)
        {
            var _loai = new LoaiVN
            {
                MaLoai = loais.Max(lo => lo.MaLoai) + 1,
                TenLoai = loai.TenLoai
            };
            loais.Add(_loai);
            return _loai;
        }

        public void Delete(int id)
        {
            var _loai = loais.SingleOrDefault(lo => lo.MaLoai == id);
            loais.Remove(_loai);
        }

        public List<LoaiVN> GetAll()
        {
            return loais;
        }

        public LoaiVN GetById(int id)
        {
            return loais.SingleOrDefault(lo => lo.MaLoai == id);
        }

        public void Upadate(LoaiVN loai)
        {
            var _loai = loais.SingleOrDefault(lo => lo.MaLoai == loai.MaLoai);
                if (_loai != null)
                {
                    _loai.TenLoai = loai.TenLoai;
                }
        }
    }
}
