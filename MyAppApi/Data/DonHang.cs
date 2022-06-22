using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAppApi.Data
{
    public enum TinhTrangDonHnag
    {
        New = 0, payment= 1, Complete = 2, Canel = -1
    }
    public class DonHang
    {
        public Guid MaDh { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? MgayGiao { get; set; }
        public int  TinhTrangDonHang { get; set; }
        public string NguoiNhan { get; set; }
        public string DIaChiGiao { get; set; }
        public string SoDienThoai { get; set; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }
        public DonHang()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }
    }
}
