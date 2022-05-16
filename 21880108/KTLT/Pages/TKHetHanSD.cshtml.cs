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
    public class TKHetHanSDModel : PageModel
    {
        public DsSanpham dsSanpham;
        public TKHetHanSDModel()
        {
            dsSanpham = new DsSanpham();
        }
        public void OnGet()
        {
            dsSanpham =  HetHSDSvc.LayDsHetHSD();


        }
    }
}