using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT.Entity;
using KTLT.DAL;
using Newtonsoft.Json;
using System.IO;
using KTLT.Services;

namespace KTLT.Pages
{
    public class LoaiSanphamModel : PageModel
    {
        public DsChungLoai dsloai;
        [BindProperty]
        public string keyword { get; set; }
        public void OnGet()
        { 
           dsloai =  ChungLoaiSvc.LayTatCaChungLoai();
           string action = HttpContext.Request.Query["action"];
            string code = HttpContext.Request.Query["code"];
            if (action == "delete")
            {
                if (!string.IsNullOrEmpty(code))
                {

                    bool result = ChungLoaiSvc.XoaLoaiSp(code);
                    Response.Redirect("./LoaiSanpham");
                }
            }
        }

        public void OnPost()
        {
            dsloai = ChungLoaiSvc.LayTatCaChungLoai();
            DsChungLoai new_ds = new DsChungLoai();
            new_ds.dsloai = new ChungLoai[dsloai.dsloai.Length];
            int index = 0;
            if (keyword == null)
                return;
            else
            {
                for (int i = 0; i < dsloai.dsloai.Length; i++)
                {

                    if (dsloai.dsloai[i].MaChungLoai.ToLower().Contains(keyword.ToLower()))
                    {
                        new_ds.dsloai[index] = dsloai.dsloai[i];
                        index++;
                    }
                }
                dsloai = new_ds;
            }
            
        }
    }
}