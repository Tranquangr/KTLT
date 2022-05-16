using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entity;
using KTLT.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KTLT.Pages
{
    public class TaoHoaDonNHModel : PageModel
    {
        [BindProperty]
        public string shd { get; set; }

        [BindProperty]
        public string masp1 { get; set; }
        [BindProperty]
        public string sl1 { get; set; }
        [BindProperty]
        public string masp2 { get; set; }
        [BindProperty]
        public string sl2 { get; set; }
        public DsSanpham dsSanpham { get; set; }
        public TaoHoaDonNHModel()
        {
            dsSanpham = new DsSanpham();
        }

        public void OnGet()
        {

            dsSanpham = SanPhamSvc.LayDsSanpham();

        }
        public void OnPost()
        {

            dsSanpham = SanPhamSvc.LayDsSanpham();
            HoaDonNhap hoaDon = new HoaDonNhap() { SoHD = shd, NgayHD = DateTime.Today };
            Sanpham sp1 = new Sanpham();
            Sanpham sp2 = new Sanpham();
            DsSanpham dsSanpham2 = SanPhamSvc.LayDsSanpham();

            for (int i2 = 0; i2 < dsSanpham2.DsSp.Length; i2++)
            {
                if (!string.IsNullOrEmpty(sl1) && !string.IsNullOrEmpty(masp1) && (masp1 == dsSanpham2.DsSp[i2].Masp))
                {
                    sp1 = dsSanpham2.DsSp[i2];
                    
                    sp1.TonKho.SLNhap = float.Parse(sl1);
                }
                if (!string.IsNullOrEmpty(sl2) && !string.IsNullOrEmpty(masp2) && (masp2 == dsSanpham2.DsSp[i2].Masp))
                {
                    sp2 = dsSanpham2.DsSp[i2];
                  
                    sp2.TonKho.SLNhap = float.Parse(sl2);
                }
            }
            Sanpham[] sp_arr = new Sanpham[2];
            if (!string.IsNullOrEmpty(sp1.Masp) && !string.IsNullOrEmpty(sp2.Masp))
            {
                sp_arr[0] = sp2;
                sp_arr[1] = sp1;
            }
            else if (!string.IsNullOrEmpty(sp1.Masp))
            {
                sp_arr = new Sanpham[1];
                sp_arr[0] = sp1;
            }
            else if (!string.IsNullOrEmpty(sp2.Masp))
            {
                sp_arr = new Sanpham[1];
                sp_arr[0] = sp2;
            }


            hoaDon.DsSp = new DsSanpham { DsSp = sp_arr };
            HoaDonNhapSvc.LuuHoaDonNhap(hoaDon);

        }
    }
}