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
    public class ThemSanphamModel : PageModel
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
        public  DsChungLoai dsChungLoai = new DsChungLoai();
        public ThemSanphamModel()
        {
            dsChungLoai = ChungLoaiSvc.LayTatCaChungLoai();

        }
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            ChungLoai chungLoai = new ChungLoai();
            bool fl = false;
            if (!string.IsNullOrEmpty(lsp))
            {
                DsChungLoai dsChungLoai = ChungLoaiSvc.LayTatCaChungLoai();
               
                if (dsChungLoai != null)
                {
                    if (dsChungLoai.dsloai != null)
                    {
                        for (int i = 0; i < dsChungLoai.dsloai.Length; i++)
                        {
                            if (dsChungLoai.dsloai[i].MaChungLoai == lsp)
                            {
                                fl = true;
                                chungLoai.MaChungLoai = lsp;
                                chungLoai.TenChungLoai = dsChungLoai.dsloai[i].TenChungLoai;

                                Sanpham sanpham = new Sanpham();
                                sanpham.Masp = masp;
                                sanpham.Tensp = tensp;
                                sanpham.HSD = hsd;
                                sanpham.NhaSx = nhasx;
                                sanpham.NgaySx = nsx;
                                sanpham.LoaiSp = chungLoai;
                                sanpham.TonKho = new TonKho();
                                sanpham.gia = gia;
                                SanPhamSvc.LuuSanpham(sanpham);

                                break;
                            }
                        }

                        
                    }
                }
                Response.Redirect("/Sanpham");

            } else
            {
                // chua co loai nao
                ViewData["info"] = "Loại sản phẩm không tồn tại";

            }
           
            

        }
    }
}