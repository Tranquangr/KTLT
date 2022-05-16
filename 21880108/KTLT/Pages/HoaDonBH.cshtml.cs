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
    public class HoaDonBH : PageModel
    {
        public DsHoaDonXuat dsHoaDon;
        [BindProperty]
        public string keyword { get; set; }
        [BindProperty]
        public DateTime date { get; set; }
        public HoaDonBH()
        {
            dsHoaDon = new DsHoaDonXuat();
        }

        public void OnGet()
        {
            dsHoaDon = HoaDonXuatSvc.LayTatCaHoaDonXuat();
            string id = HttpContext.Request.Query["id"].ToString();
            string action = HttpContext.Request.Query["act"].ToString();

            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(action))
            {
                if (action == "delete")
                {
                    HoaDonXuatSvc.XoaHoaDonXuat(id);
                    Response.Redirect("/HoaDonBH");
                }
               
            }

        }
        public void OnPost()
        {
            dsHoaDon = HoaDonXuatSvc.LayTatCaHoaDonXuat();
            DsHoaDonXuat new_ds = new DsHoaDonXuat();
            new_ds.HoaDon_arr = new HoaDonXuat[dsHoaDon.HoaDon_arr.Length];
            int index = 0;
            if (!string.IsNullOrEmpty(keyword))
            {
                for (int i = 0; i < dsHoaDon.HoaDon_arr.Length; i++)
                {

                    if (dsHoaDon.HoaDon_arr[i].SoHD.ToLower().Contains(keyword.ToLower()))
                    {
                        new_ds.HoaDon_arr[index] = dsHoaDon.HoaDon_arr[i];
                        index++;
                    }
                }

                dsHoaDon = new_ds;
            }
            
           
            

            if (date != new DateTime())
            {
                for (int i = 0; i < dsHoaDon.HoaDon_arr.Length; i++)
                {

                    if (dsHoaDon.HoaDon_arr[i].NgayHD == date)
                    {
                        new_ds.HoaDon_arr[index] = dsHoaDon.HoaDon_arr[i];
                        index++;
                    }
                }
                dsHoaDon = new_ds;
            }
        }
    }
}