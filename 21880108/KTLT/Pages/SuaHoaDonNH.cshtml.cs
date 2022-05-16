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
    public class SuaHoaDonNHModel : PageModel
    {
        public DsHoaDonNhap dsHoaDon;
        public HoaDonNhap hoaDonNH { get; set; }
        public DsSanpham dsSanpham { get; set; }
        public DsChungLoai dsloai { get; set; }
        [BindProperty]
        public string masp { get; set; }
        [BindProperty]
        public string sl { get; set; }
        [BindProperty]
        public string shd { get; set; }

        public SuaHoaDonNHModel()
        {
            dsHoaDon = new DsHoaDonNhap();
           
            hoaDonNH = new HoaDonNhap();
        }
        public void OnGet()
        {
            string shd = HttpContext.Request.Query["id"].ToString();
            dsHoaDon = HoaDonNhapSvc.LayTatCaHoaDonNhap();
            dsSanpham = SanPhamSvc.LayDsSanpham();
            hoaDonNH = HoaDonNhapSvc.LayHoaDonNHTheoId(shd);

        } 

        public void OnPost()
        {
            dsSanpham = SanPhamSvc.LayDsSanpham();
            dsHoaDon = HoaDonNhapSvc.LayTatCaHoaDonNhap();
            dsloai = ChungLoaiSvc.LayTatCaChungLoai();
            if (!string.IsNullOrEmpty(masp) && !string.IsNullOrEmpty(sl))
            {
                string tens1 = "";

                for (int i = 0; i < dsSanpham.DsSp.Length; i++)
                {
                    if (dsSanpham.DsSp[i].Masp == masp)
                    {
                        tens1 = dsSanpham.DsSp[i].Tensp;
                    }


                }

                for (int i = 0; i < dsHoaDon.HoaDon_arr.Length; i++)
                {

                    if (dsHoaDon.HoaDon_arr[i].SoHD == shd)
                    {

                        for (int i2 = 0; i2 < dsHoaDon.HoaDon_arr[i].DsSp.DsSp.Length; i2++)
                        {
                            if (dsHoaDon.HoaDon_arr[i].DsSp.DsSp[i2].Masp == masp)
                            {

                                dsHoaDon.HoaDon_arr[i].DsSp.DsSp[i2].Tensp = tens1;
                                dsHoaDon.HoaDon_arr[i].DsSp.DsSp[i2].TonKho.SLNhap = float.Parse(sl);
                            }
                        }

                    }
                }

            }
            HoaDonNhapSvc.LuuDsHoaDonNhap(dsHoaDon);
        }
    }
}