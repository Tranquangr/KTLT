using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Entity
{
    public class Sanpham
    {
        public string Masp { get; set; }
        public string Tensp { get; set; }
        public DateTime HSD { get; set; }
        public string NhaSx { get; set; }
        public DateTime NgaySx { get; set; }
        public ChungLoai LoaiSp { get; set; }

        public int gia { get; set ; }
        public TonKho TonKho { get; set; }
        
    }
}
