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
    public class ThemLoaiModel : PageModel
    {
        [BindProperty]
        public string mcl { get; set; }
        [BindProperty]
        public string tcl { get; set; }
        public string notify { get; set; }
        private ChungLoai chungLoai;
        public ThemLoaiModel()
        {
            chungLoai = new ChungLoai();
        }
        public void OnPost()
        {
            if ( !string.IsNullOrEmpty(mcl) && !string.IsNullOrEmpty(tcl))
            {
                chungLoai.MaChungLoai = mcl;
                chungLoai.TenChungLoai = tcl;
                
                int result = ChungLoaiSvc.LuuLoaiSp(chungLoai);
                Response.Redirect("/LoaiSanpham");
            }
            
        }
    }
}