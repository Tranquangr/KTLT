using KTLT.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.DAL
{
    public class LT_HoaDonXuat
    {

        public static bool LuuHoaDonBH(string value, string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    StreamWriter file = new StreamWriter(path);
                    file.WriteLine(value);
                    file.Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static DsHoaDonXuat LayTatCaHoaDonBH()
        {
            try
            {
                DsHoaDonXuat dsHoaDonXuat = new DsHoaDonXuat();
                string path = Constants.path_hdx;
                StreamReader file = new StreamReader(path);
                string jsonText = file.ReadToEnd();
                file.Close();
                dsHoaDonXuat = JsonConvert.DeserializeObject<DsHoaDonXuat>(jsonText);
                if (dsHoaDonXuat == null)
                {
                    return new DsHoaDonXuat();
                }
                return dsHoaDonXuat;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

