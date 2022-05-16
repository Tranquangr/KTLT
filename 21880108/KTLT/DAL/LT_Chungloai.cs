using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entity;
using Newtonsoft.Json;

namespace KTLT.DAL
{
    public class LT_Chungloai
    {
        public static bool LuuChungLoai(string value , string path)
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
            } catch (Exception ex)
            {
                return false;
            } 

        }
        public static DsChungLoai LayTatCaChungLoai()
        {
            try
            {
                DsChungLoai dsChungLoai = new DsChungLoai();
                string path = Constants.path_cl;
                StreamReader file = new StreamReader(path);
                string jsonText = file.ReadToEnd();
                file.Close();
                dsChungLoai = JsonConvert.DeserializeObject<DsChungLoai>(jsonText);
                if (dsChungLoai == null)
                {
                    return new DsChungLoai();
                }
                return dsChungLoai;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
