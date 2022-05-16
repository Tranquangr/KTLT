using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Entity
{
    public class TonKho
    {
        public float SLNhap { get; set; }
        public float SLXuat { get; set; }
        public float SLTon { get { return this.SLNhap - this.SLXuat; } }
        public TonKho()
        {
            this.SLNhap = 0;
            this.SLXuat = 0;
        }
        public TonKho(float nhap , float xuat)
        {
            this.SLNhap = nhap;
            this.SLXuat = xuat;
        }
    }
}
