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
    public class TKTonKhoModel : PageModel
    {
        public DsTonKho_Loai dstonkho;
        public TKTonKhoModel()
        {
            dstonkho = new DsTonKho_Loai();
        }
        public void OnGet()
        {
             dstonkho =  TonKho_LoaiSvc.LayTonKho();
        }
    }
}