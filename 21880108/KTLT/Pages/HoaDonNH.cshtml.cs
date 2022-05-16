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
    public class HoaDonNHModel : PageModel
    {
        public DsHoaDonNhap dsHoaDonNH;
        [BindProperty]
        public string keyword { get; set; }
        [BindProperty]
        public DateTime date { get; set; }
        public HoaDonNHModel()
        {
            dsHoaDonNH = new DsHoaDonNhap();
            dsHoaDonNH = HoaDonNhapSvc.LayTatCaHoaDonNhap();

        }

        public void OnGet()
        {
            dsHoaDonNH = HoaDonNhapSvc.LayTatCaHoaDonNhap();
            string id = HttpContext.Request.Query["id"].ToString();
            string action = HttpContext.Request.Query["act"].ToString();

            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(action))
            {
                if (action == "delete")
                {
                    HoaDonNhapSvc.XoaHoaDonNH(id);
                    Response.Redirect("/HoaDonNH");
                }

            }

        }

        public void OnPost()
        {
            dsHoaDonNH = HoaDonNhapSvc.LayTatCaHoaDonNhap();
            DsHoaDonNhap new_ds = new DsHoaDonNhap();
            new_ds.HoaDon_arr = new HoaDonNhap[dsHoaDonNH.HoaDon_arr.Length];
            int index = 0;
            if (!string.IsNullOrEmpty(keyword))
            {
                for (int i = 0; i < dsHoaDonNH.HoaDon_arr.Length; i++)
                {

                    if (dsHoaDonNH.HoaDon_arr[i].SoHD.ToLower() == keyword.ToLower())
                    {
                        new_ds.HoaDon_arr[index] = dsHoaDonNH.HoaDon_arr[i];
                        index++;
                    }
                }
                dsHoaDonNH = new_ds;
            }
            if (date != new DateTime())
            {
                for (int i = 0; i < dsHoaDonNH.HoaDon_arr.Length; i++)
                {

                    if (dsHoaDonNH.HoaDon_arr[i].NgayHD == date)
                    {
                        new_ds.HoaDon_arr[index] = dsHoaDonNH.HoaDon_arr[i];
                        index++;
                    }
                }
                dsHoaDonNH = new_ds;
            }

        }
    }
}