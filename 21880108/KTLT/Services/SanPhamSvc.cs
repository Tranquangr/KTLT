using KTLT.DAL;
using KTLT.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Services
{
    public class SanPhamSvc
    {
        public static DsSanpham LayDsSanpham()
        {
            return LT_Sanpham.LayTatCaSanpham();
        }
      
        public static int LuuSanpham(Sanpham sanpham)
        {
            try
            {
                DsSanpham dsSp = new DsSanpham();
                dsSp = LayDsSanpham();
                DsSanpham new_ds = new DsSanpham();
       
                if (sanpham != null)
                {
                    if (dsSp.DsSp != null)
                    {
                        if (dsSp.DsSp.Length == 0)
                        {
                            new_ds.DsSp = new Sanpham[1];
                            new_ds.DsSp[0] = sanpham;

                        }
                        if (dsSp.DsSp.Length > 0)
                        {
                            new_ds.DsSp = new Sanpham[dsSp.DsSp.Length + 1];
                            for (int i = 0; i < dsSp.DsSp.Length; i++)
                            {
                                if (dsSp.DsSp[i].Masp == sanpham.Masp)
                                {
                                    return 0;
                                }
                                new_ds.DsSp[i] = dsSp.DsSp[i];
                            }
                            new_ds.DsSp[new_ds.DsSp.Length - 1] = sanpham;

                        }

                    }
                    else
                    {
                        new_ds.DsSp = new Sanpham[1];
                        new_ds.DsSp[0] = sanpham;
                    }

                }
                string jsonText = JsonConvert.SerializeObject(new_ds);
                LT_Sanpham.LuuSanpham(jsonText, Constants.path_sp);
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static bool Suasanpham(Sanpham sanpham)
        {
            try
            {
                DsSanpham dsSanpham = LayDsSanpham();
                DsSanpham new_ds = new DsSanpham();
                if (dsSanpham != null)
                {
                    for (int i=0; i< dsSanpham.DsSp.Length;i++ )
                    {
                        if (dsSanpham.DsSp[i].Masp == sanpham.Masp)
                        {
                            dsSanpham.DsSp[i].Tensp = sanpham.Tensp;
                            dsSanpham.DsSp[i].HSD = sanpham.HSD;
                            dsSanpham.DsSp[i].NhaSx = sanpham.NhaSx;
                            dsSanpham.DsSp[i].NgaySx = sanpham.NgaySx;
                            dsSanpham.DsSp[i].LoaiSp = sanpham.LoaiSp;
                            dsSanpham.DsSp[i].gia = sanpham.gia;
                            break;
                        }
                    }
                    LT_Sanpham.LuuSanpham(JsonConvert.SerializeObject(dsSanpham), Constants.path_sp);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool XoaSanpham(string code)
        {
            try
            {
                DsSanpham dsSanpham = LayDsSanpham();
                DsSanpham new_ds = new DsSanpham();
                
                if (dsSanpham != null)
                {
                    if (dsSanpham.DsSp != null)
                    {
                        for (int i = 0; i < dsSanpham.DsSp.Length; i++)
                        {

                            if (dsSanpham.DsSp[i].Masp == code)
                            {
                                new_ds.DsSp = new Sanpham[dsSanpham.DsSp.Length - 1];
                                int count = 0;
                                for (int j1 = 0; j1 < i; j1++)
                                {
                                    new_ds.DsSp[count] = dsSanpham.DsSp[j1];
                                    count++;
                                }
                                for (int j2 = i + 1; j2 < dsSanpham.DsSp.Length; j2++)
                                {
                                    new_ds.DsSp[count] = dsSanpham.DsSp[j2];
                                    count++;
                                }
                            }
                        }

                        LT_Sanpham.LuuSanpham(JsonConvert.SerializeObject(new_ds), Constants.path_sp);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
