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
    public class TaoHoaDonBHModel : PageModel
    {
        [BindProperty]
        public string shd { get; set; }
      
        [BindProperty]
        public string masp1 { get; set; }
        [BindProperty]
        public string sl1 { get; set; }

        [BindProperty]
      
        public DsSanpham dsSanpham { get; set; }
        public TaoHoaDonBHModel()
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
            HoaDonXuat hoaDon = new HoaDonXuat() { SoHD = shd, NgayHD = DateTime.Today };
            Sanpham sp1 = new Sanpham();
            DsSanpham dsSanpham2 = SanPhamSvc.LayDsSanpham();

            for (int i2 = 0; i2 < dsSanpham2.DsSp.Length; i2++)
            {
                if (!string.IsNullOrEmpty(sl1) && !string.IsNullOrEmpty(masp1) && (masp1 == dsSanpham2.DsSp[i2].Masp))
                {
                    sp1 = dsSanpham2.DsSp[i2];
                    sp1.TonKho = new TonKho();
                    sp1.TonKho.SLXuat = float.Parse(sl1);
                    hoaDon.Soluong = float.Parse(sl1);
                }
                
            }
            Sanpham[] sp_arr = new Sanpham[1];
            if (!string.IsNullOrEmpty(sp1.Masp))
            {
                sp_arr[0] = sp1;
                hoaDon.DsSp = new DsSanpham { DsSp = sp_arr };
                HoaDonXuatSvc.LuuHoaDonXuat(hoaDon);
                Response.Redirect("/HoaDonBH");
            }
            
            
        }

    }
}