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
    public class SanphamModel : PageModel
    {

        public  DsSanpham dsSp = new DsSanpham();
        [BindProperty]
        public string keyword { get; set; }
        public SanphamModel()
        {
            dsSp = SanPhamSvc.LayDsSanpham();
        }
        public void OnGet()
        {
            
            string action = HttpContext.Request.Query["act"].ToString();
            string code = HttpContext.Request.Query["code"].ToString();
            if (!string.IsNullOrEmpty(action) && !string.IsNullOrEmpty(code))
            {
                if (action == "delete")
                {
                    bool result = SanPhamSvc.XoaSanpham(code);
                    Response.Redirect("/Sanpham");
                }
                
            }

        }
        public void OnPost()
        {
            dsSp = SanPhamSvc.LayDsSanpham();
            DsSanpham new_ds = new DsSanpham();
            new_ds.DsSp = new Sanpham[dsSp.DsSp.Length];
            int index = 0;
            if(keyword == null)
            {
                return;
            }
            if (keyword != "")
            {
                for (int i = 0; i < dsSp.DsSp.Length; i++)
                {

                    if (dsSp.DsSp[i].Masp.ToLower().Contains(keyword.ToLower()))
                    {
                        new_ds.DsSp[index] = dsSp.DsSp[i];
                        index++;
                    }
                }
                dsSp = new_ds;
            }
        }
    }
}