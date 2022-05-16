using KTLT.DAL;
using KTLT.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Services
{
    public class HoaDonXuatSvc
    {
        public static int LuuHoaDonXuat(HoaDonXuat hoaDon)
        {
            try
            {
                DsHoaDonXuat dshd = new DsHoaDonXuat();
                dshd = LayTatCaHoaDonXuat();
                DsHoaDonXuat new_ds = new DsHoaDonXuat();

                if (hoaDon != null)
                {
                    if (dshd.HoaDon_arr != null)
                    {
                        if (dshd.HoaDon_arr.Length == 0)
                        {
                            new_ds.HoaDon_arr = new HoaDonXuat[1];
                            new_ds.HoaDon_arr[0] = hoaDon;

                        }
                        if (dshd.HoaDon_arr.Length > 0)
                        {
                            new_ds.HoaDon_arr = new HoaDonXuat[dshd.HoaDon_arr.Length + 1];
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
                        new_ds.HoaDon_arr = new HoaDonXuat[1];
                        new_ds.HoaDon_arr[0] = hoaDon;
                    }

                }
                string jsonText = JsonConvert.SerializeObject(new_ds);
                LT_HoaDonXuat.LuuHoaDonBH(jsonText, Constants.path_hdx);

                return 1;

            }
            catch (Exception ex)
            {
                return -1;
            }

        }

        public static DsHoaDonXuat LayTatCaHoaDonXuat()
        {
            return LT_HoaDonXuat.LayTatCaHoaDonBH();
        }

        public static HoaDonXuat LayHoaDonXuatTheoId(string id)
        {
            DsHoaDonXuat dsHDNH = LT_HoaDonXuat.LayTatCaHoaDonBH();
            for (int i = 0; i < dsHDNH.HoaDon_arr.Length; i++)
            {
                if (dsHDNH.HoaDon_arr[i].SoHD == id)
                {
                    return dsHDNH.HoaDon_arr[i];
                }
            }
            return new HoaDonXuat();
        }
        public static bool XoaHoaDonXuat(string code)
        {
            try
            {
                DsHoaDonXuat dsHoaDonXuat = LayTatCaHoaDonXuat();

                DsHoaDonXuat new_ds = new DsHoaDonXuat();

                if (dsHoaDonXuat != null)
                {
                    if (dsHoaDonXuat.HoaDon_arr != null)
                    {
                        for (int i = 0; i < dsHoaDonXuat.HoaDon_arr.Length; i++)
                        {

                            if (dsHoaDonXuat.HoaDon_arr[i].SoHD == code)
                            {
                                new_ds.HoaDon_arr = new HoaDonXuat[dsHoaDonXuat.HoaDon_arr.Length - 1];
                                int count = 0;
                                for (int j1 = 0; j1 < i; j1++)
                                {
                                    new_ds.HoaDon_arr[count] = dsHoaDonXuat.HoaDon_arr[j1];
                                    count++;
                                }
                                for (int j2 = i + 1; j2 < dsHoaDonXuat.HoaDon_arr.Length; j2++)
                                {
                                    new_ds.HoaDon_arr[count] = dsHoaDonXuat.HoaDon_arr[j2];
                                    count++;
                                }
                            }
                        }

                        LT_HoaDonXuat.LuuHoaDonBH(JsonConvert.SerializeObject(new_ds), Constants.path_hdx);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static void LuuDsHoaDonXuat(DsHoaDonXuat dsHoaDonXuat)
        {
            LT_HoaDonXuat.LuuHoaDonBH(JsonConvert.SerializeObject(dsHoaDonXuat), Constants.path_hdx);
        }
        public static bool SuaHoaDonXuat(HoaDonXuat hoaDon)
        {
            try
            {
                DsHoaDonXuat dsHoaDonXuat = LayTatCaHoaDonXuat();
                DsHoaDonXuat new_ds = new DsHoaDonXuat();
                if (dsHoaDonXuat != null)
                {
                    if (dsHoaDonXuat.HoaDon_arr != null)
                    {
                        for (int i = 0; i < dsHoaDonXuat.HoaDon_arr.Length; i++)
                        {

                            if (dsHoaDonXuat.HoaDon_arr[i].SoHD == hoaDon.SoHD)
                            {
                                dsHoaDonXuat.HoaDon_arr[i] = hoaDon;

                                break;
                            }
                        }

                        LT_HoaDonXuat.LuuHoaDonBH(JsonConvert.SerializeObject(dsHoaDonXuat), Constants.path_hdx);
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

