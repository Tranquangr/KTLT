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
    public class SuasanphamModel : PageModel
    {
        [BindProperty]
        public string masp { get; set; }
        [BindProperty]
        public string tensp { get; set; }
        [BindProperty]
        public DateTime hsd { get; set; }
        [BindProperty]
        public string nhasx { get; set; }
        [BindProperty]
        public DateTime nsx { get; set; }
        [BindProperty]
        public string lsp { get; set; }
        [BindProperty]
        public int gia { get; set; }

        public DsChungLoai dsChungLoai = new DsChungLoai();
        public SuasanphamModel()
        {
            dsChungLoai = ChungLoaiSvc.LayTatCaChungLoai();

        }

        public Sanpham sanpham = new Sanpham();
        public void OnGet()
        {
            string code = HttpContext.Request.Query["code"].ToString();
            DsSanpham ds = SanPhamSvc.LayDsSanpham();
            if (ds != null)
            {
                if (ds.DsSp != null)
                {
                    for (int i = 0; i < ds.DsSp.Length; i++)
                    {
                        if (ds.DsSp[i].Masp == code)
                        {
                            sanpham.Masp = ds.DsSp[i].Masp;
                            sanpham.Tensp = ds.DsSp[i].Tensp;
                            sanpham.HSD = ds.DsSp[i].HSD;
                            sanpham.NhaSx = ds.DsSp[i].NhaSx;
                            sanpham.NgaySx = ds.DsSp[i].NgaySx;
                            sanpham.LoaiSp = ds.DsSp[i].LoaiSp;
                            sanpham.gia = ds.DsSp[i].gia;
                        }
                    }
                }
            }
        }

        public void Onpost()
        {
            ChungLoai chungloai = new ChungLoai();
            DsChungLoai dsChungLoai = ChungLoaiSvc.LayTatCaChungLoai();
            sanpham.Masp = masp;
            sanpham.Tensp = tensp;
            sanpham.HSD = hsd;
            sanpham.NhaSx = nhasx;
            sanpham.NgaySx = nsx;
            for (int i = 0; i < dsChungLoai.dsloai.Length; i++)
            {
                if (dsChungLoai.dsloai[i].MaChungLoai == lsp)
                {
                    chungloai.MaChungLoai = lsp;
                    chungloai.TenChungLoai = dsChungLoai.dsloai[i].TenChungLoai;
                }
            }
            sanpham.LoaiSp = chungloai;
            sanpham.gia = gia;
            bool result = SanPhamSvc.Suasanpham(sanpham);
            Response.Redirect("/Sanpham");
        }
    }
}
