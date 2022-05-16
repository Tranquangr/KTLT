using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Entity
{
    public class HoaDonXuat
    {
        public string SoHD { get; set; }
        public DsSanpham DsSp { get; set; }
        public float Soluong { get; set; }
        public DateTime NgayHD { get; set; }
       
    }
}
