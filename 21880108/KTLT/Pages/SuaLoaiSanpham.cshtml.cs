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
    public class SuaLoaiSanphamModel : PageModel
    {
        [BindProperty]
        public string mcl { get; set; }
        [BindProperty]
        public string tcl { get; set; }
        
        public ChungLoai chungLoai = new ChungLoai();
       
        
        public void OnGet()
        {
            string code = HttpContext.Request.Query["code"].ToString();
            DsChungLoai ds = ChungLoaiSvc.LayTatCaChungLoai();
            
            if (ds != null)
            {
                if (ds.dsloai != null)
                {
                    for (int i = 0; i < ds.dsloai.Length;i++)
                    {
                        if (ds.dsloai[i].MaChungLoai == code)
                        {
                            chungLoai.MaChungLoai = ds.dsloai[i].MaChungLoai;
                            chungLoai.TenChungLoai = ds.dsloai[i].TenChungLoai;

                        }
                    }
                }
            }

        }
        public void OnPost()
        {
            if (!string.IsNullOrEmpty(mcl) && !string.IsNullOrEmpty(tcl))
            {
                chungLoai.MaChungLoai = mcl;
                chungLoai.TenChungLoai = tcl;
                bool result = ChungLoaiSvc.SuaLoaiSp(chungLoai);
                Response.Redirect("/LoaiSanpham");
               
            }
        }
    }
}