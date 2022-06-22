using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAppApi.Models
{
    public class HangHoaVN
    {
        public string TenHangHoa { get; set; }
        public double DonGia { get; set; }
    }
    public class HangHoa : HangHoaVN
    {
        public Guid MaHangHoa { get; set; }

    }
}
