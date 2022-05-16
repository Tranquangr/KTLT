using KTLT.DAL;
using KTLT.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Services
{
    public class ChungLoaiSvc
    {
        public static int LuuLoaiSp(ChungLoai chungLoai)
        {
            try
            {
                DsChungLoai dsloai = new DsChungLoai();
                dsloai = LayTatCaChungLoai();
                DsChungLoai new_ds = new DsChungLoai();

                if (chungLoai != null)
                {
                    if (dsloai.dsloai != null)
                    {
                        if (dsloai.dsloai.Length == 0)
                        {
                            new_ds.dsloai = new ChungLoai[1];
                            new_ds.dsloai[0] = chungLoai;

                        }
                        if (dsloai.dsloai.Length > 0)
                        {
                            new_ds.dsloai = new ChungLoai[dsloai.dsloai.Length + 1];
                            for (int i = 0; i < dsloai.dsloai.Length; i++)
                            {
                                if (dsloai.dsloai[i].MaChungLoai == chungLoai.MaChungLoai)
                                {
                                    return 0;
                                }
                                new_ds.dsloai[i] = dsloai.dsloai[i];
                            }
                            new_ds.dsloai[new_ds.dsloai.Length - 1] = chungLoai;

                        }
                        
                    } else
                    {
                        new_ds.dsloai = new ChungLoai[1];
                        new_ds.dsloai[0] = chungLoai;
                    }
                    
                }
                string jsonText = JsonConvert.SerializeObject(new_ds);
                LT_Chungloai.LuuChungLoai(jsonText, Constants.path_cl);

                return 1;
                
            } catch (Exception ex)
            {
                return -1;
            }
            
            
             
        }

        public static DsChungLoai LayTatCaChungLoai()
        { 
            return   LT_Chungloai.LayTatCaChungLoai();
        }
        public static bool XoaLoaiSp(string code)
        {
            try
            {
                DsChungLoai dsChungLoai = LayTatCaChungLoai();
                DsSanpham dsSanpham = SanPhamSvc.LayDsSanpham();
                DsChungLoai new_ds = new DsChungLoai();
                for (int i = 0; i < dsSanpham.DsSp.Length; i++)
                {
                    if (dsSanpham.DsSp[i].LoaiSp.MaChungLoai == code)
                    {
                        return false;
                    }
                }
                if (dsChungLoai != null)
                {
                    if (dsChungLoai.dsloai != null)
                    {
                        for (int i = 0; i < dsChungLoai.dsloai.Length; i++)
                        {
                            
                            if (dsChungLoai.dsloai[i].MaChungLoai == code)
                            {
                                new_ds.dsloai = new ChungLoai[dsChungLoai.dsloai.Length - 1];
                                int count = 0;
                                for (int j1 = 0; j1 < i; j1++)
                                {
                                    new_ds.dsloai[count] = dsChungLoai.dsloai[j1];
                                    count++;
                                }
                                for (int j2 =i+1; j2 < dsChungLoai.dsloai.Length;j2++)
                                {
                                    new_ds.dsloai[count] = dsChungLoai.dsloai[j2];
                                    count++;
                                }
                            }
                        }

                        LT_Chungloai.LuuChungLoai(JsonConvert.SerializeObject(new_ds), Constants.path_cl);
                    }
                }
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }
        public static bool SuaLoaiSp(ChungLoai chungLoai)
        {
            try
            {
                DsChungLoai dsChungLoai = LayTatCaChungLoai();
                DsChungLoai new_ds = new DsChungLoai();
                if (dsChungLoai != null)
                {
                    if (dsChungLoai.dsloai != null)
                    {
                        for (int i = 0; i < dsChungLoai.dsloai.Length; i++)
                        {

                            if (dsChungLoai.dsloai[i].MaChungLoai == chungLoai.MaChungLoai)
                            {
                                dsChungLoai.dsloai[i].TenChungLoai = chungLoai.TenChungLoai;
                                break;
                            }
                        }

                        LT_Chungloai.LuuChungLoai(JsonConvert.SerializeObject(dsChungLoai), Constants.path_cl);
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
