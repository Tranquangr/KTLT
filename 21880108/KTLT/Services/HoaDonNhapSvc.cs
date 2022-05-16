using KTLT.DAL;
using KTLT.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Services
{
    public class HoaDonNhapSvc
    {
        public static int LuuHoaDonNhap(HoaDonNhap hoaDon)
        {
            try
            {
                DsHoaDonNhap dshd = new DsHoaDonNhap();
                dshd = LayTatCaHoaDonNhap();
                DsHoaDonNhap new_ds = new DsHoaDonNhap();

                if (hoaDon != null)
                {
                    if (dshd.HoaDon_arr != null)
                    {
                        if (dshd.HoaDon_arr.Length == 0)
                        {
                            new_ds.HoaDon_arr = new HoaDonNhap[1];
                            new_ds.HoaDon_arr[0] = hoaDon;

                        }
                        if (dshd.HoaDon_arr.Length > 0)
                        {
                            new_ds.HoaDon_arr = new HoaDonNhap[dshd.HoaDon_arr.Length + 1];
                            for (int i = 0; i < dshd.HoaDon_arr.Length; i++)
                            {
                                if (dshd.HoaDon_arr[i].SoHD == hoaDon.SoHD)
                                {
                                    return 0;
                                }
                                new_ds.HoaDon_arr[i] = dshd.HoaDon_arr[i];
                            }
                            new_ds.HoaDon_arr[new_ds.HoaDon_arr.Length - 1] = hoaDon;

                        }

                    }
                    else
                    {
                        new_ds.HoaDon_arr = new HoaDonNhap[1];
                        new_ds.HoaDon_arr[0] = hoaDon;
                    }

                }
                string jsonText = JsonConvert.SerializeObject(new_ds);
                LT_HoaDonNhap.LuuHoaDonNhap(jsonText, Constants.path_hdn);

                return 1;

            }
            catch (Exception ex)
            {
                return -1;
            }

        }

        public static DsHoaDonNhap LayTatCaHoaDonNhap()
        {
            return LT_HoaDonNhap.LayTatCaHoaDonNhap();
        }

        public static HoaDonNhap LayHoaDonNHTheoId(string id)
        {
            DsHoaDonNhap dsHDNH = LT_HoaDonNhap.LayTatCaHoaDonNhap();
            for (int i = 0; i < dsHDNH.HoaDon_arr.Length; i++)
            {
                if (dsHDNH.HoaDon_arr[i].SoHD == id)
                {
                    return dsHDNH.HoaDon_arr[i];
                }
            }
            return new HoaDonNhap();
        }
        public static bool XoaHoaDonNH(string code)
        {
            try
            {
                DsHoaDonNhap dsHoaDonNH = LayTatCaHoaDonNhap();

                DsHoaDonNhap new_ds = new DsHoaDonNhap();

                if (dsHoaDonNH != null)
                {
                    if (dsHoaDonNH.HoaDon_arr != null)
                    {
                        for (int i = 0; i < dsHoaDonNH.HoaDon_arr.Length; i++)
                        {

                            if (dsHoaDonNH.HoaDon_arr[i].SoHD == code)
                            {
                                new_ds.HoaDon_arr = new HoaDonNhap[dsHoaDonNH.HoaDon_arr.Length - 1];
                                int count = 0;
                                for (int j1 = 0; j1 < i; j1++)
                                {
                                    new_ds.HoaDon_arr[count] = dsHoaDonNH.HoaDon_arr[j1];
                                    count++;
                                }
                                for (int j2 = i + 1; j2 < dsHoaDonNH.HoaDon_arr.Length; j2++)
                                {
                                    new_ds.HoaDon_arr[count] = dsHoaDonNH.HoaDon_arr[j2];
                                    count++;
                                }
                            }
                        }

                        LT_HoaDonNhap.LuuHoaDonNhap(JsonConvert.SerializeObject(new_ds), Constants.path_hdn);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static void LuuDsHoaDonNhap(DsHoaDonNhap dsHoaDonNhap)
        {
            LT_HoaDonNhap.LuuHoaDonNhap(JsonConvert.SerializeObject(dsHoaDonNhap), Constants.path_hdn);
        }
        public static bool SuaHoaDonNH(HoaDonNhap hoaDon)
        {
            try
            {
                DsHoaDonNhap dsHoaDonNH = LayTatCaHoaDonNhap();
                DsHoaDonNhap new_ds = new DsHoaDonNhap();
                if (dsHoaDonNH != null)
                {
                    if (dsHoaDonNH.HoaDon_arr != null)
                    {
                        for (int i = 0; i < dsHoaDonNH.HoaDon_arr.Length; i++)
                        {

                            if ( dsHoaDonNH.HoaDon_arr[i].SoHD == hoaDon.SoHD)
                            {
                                dsHoaDonNH.HoaDon_arr[i] = hoaDon;

                                break;
                            }
                        }

                        LT_HoaDonNhap.LuuHoaDonNhap(JsonConvert.SerializeObject(dsHoaDonNH), Constants.path_hdn);
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
