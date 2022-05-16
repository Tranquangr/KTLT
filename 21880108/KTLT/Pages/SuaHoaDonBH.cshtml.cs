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
    public class SuaHoaDonBHModel : PageModel
    {
        public DsHoaDonXuat dsHoaDon;
        public HoaDonXuat hoaDonBH { get; set; }
        public DsSanpham dsSanpham { get; set; }
        public DsChungLoai dsloai { get; set; }
        [BindProperty]
        public string masp1 { get; set; }
        [BindProperty]
        public string sl1 { get; set; }

        [BindProperty]
        public string shd { get; set; }

        public Sanpham sanpham = new Sanpham();

        public SuaHoaDonBHModel()
        {
            dsHoaDon = new DsHoaDonXuat();
            dsSanpham = new DsSanpham();
            hoaDonBH = new HoaDonXuat();
            dsloai = new DsChungLoai();
        }
        public void OnGet()
        {
            string shd = HttpContext.Request.Query["id"].ToString();
            dsHoaDon = HoaDonXuatSvc.LayTatCaHoaDonXuat();
            dsSanpham = SanPhamSvc.LayDsSanpham();
            hoaDonBH = HoaDonXuatSvc.LayHoaDonXuatTheoId(shd);
            sanpham = hoaDonBH.DsSp.DsSp[0];

        }

        public void OnPost()
        {
            dsSanpham = SanPhamSvc.LayDsSanpham();
            dsHoaDon = HoaDonXuatSvc.LayTatCaHoaDonXuat();
            dsloai = ChungLoaiSvc.LayTatCaChungLoai();
            if (!string.IsNullOrEmpty(masp1) && !string.IsNullOrEmpty(sl1))
            {
                string tens1 = "";

                for (int i = 0; i < dsSanpham.DsSp.Length; i++)
                {
                    if (dsSanpham.DsSp[i].Masp == masp1)
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
                            if (dsHoaDon.HoaDon_arr[i].DsSp.DsSp[i2].Masp == masp1)
                            {

                                dsHoaDon.HoaDon_arr[i].DsSp.DsSp[i2].Tensp = tens1;
                                dsHoaDon.HoaDon_arr[i].DsSp.DsSp[i2].TonKho.SLXuat = float.Parse(sl1);
                                dsHoaDon.HoaDon_arr[i].Soluong = float.Parse(sl1);
                            }
                        }

                    }
                }

            }
            Response.Redirect("/HoaDonBH");
            HoaDonXuatSvc.LuuDsHoaDonXuat(dsHoaDon);
        }
    }
}