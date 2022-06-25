using MyAppApi.Models;
using System.Collections.Generic;

namespace MyAppApi.Sevices
{
    public interface ILoaiRepository 
    {
        List<LoaiVN> GetAll();
        LoaiVN GetById(int id);
        LoaiVN Add(LoaiModel loai);
        void Upadate(LoaiVN loai);
        void Delete(int id);
    }
}
