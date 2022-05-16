using KTLT.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.DAL
{
    public class LT_HoaDonNhap
    {
        public static bool LuuHoaDonNhap(string value, string path)
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
        public static DsHoaDonNhap LayTatCaHoaDonNhap()
        {
            try
            {
                DsHoaDonNhap dsHoaDonNH = new DsHoaDonNhap();
                string path = Constants.path_hdn;
                StreamReader file = new StreamReader(path);
                string jsonText = file.ReadToEnd();
                file.Close();
                dsHoaDonNH = JsonConvert.DeserializeObject<DsHoaDonNhap>(jsonText);
                if (dsHoaDonNH == null)
                {
                    return new DsHoaDonNhap();
                }
                return dsHoaDonNH;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
