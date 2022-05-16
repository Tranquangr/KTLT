using KTLT.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.DAL
{
    public class LT_Sanpham
    {
        public static string DocTatCaSanPham()
        {
            StreamReader file = new StreamReader("data/sanpham.json");
            string jsonText = file.ReadToEnd();
            Console.WriteLine(jsonText);
            return jsonText;
        }
        public static void TaoTatCaFileData()
        {
            if (!File.Exists("data/sanpham.json"))
            {
                File.Create("data/sanpham.json");
            }
            if (!File.Exists("data/chungloai.json"))
            {
                File.Create("data/chungloai.json");
            }
            if (!File.Exists("data/hoadonxuat.json"))
            {
                File.Create("data/hoadonxuat.json");
            }
            if (!File.Exists("data/hoadonnhap.json"))
            {
                File.Create("data/hoadonnhap.json");
            }

        }

        public static bool LuuSanpham (string value, string path)
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
        public static DsSanpham LayTatCaSanpham()
        {
            try
            {
                DsSanpham dsSanpham = new DsSanpham();
                string path = Constants.path_sp;
                StreamReader file = new StreamReader(path);
                string jsonText = file.ReadToEnd();
                file.Close();
                dsSanpham = JsonConvert.DeserializeObject<DsSanpham>(jsonText);
                if (dsSanpham == null)
                {
                    return new DsSanpham();
                }
                return dsSanpham;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
