using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entity;
namespace KTLT.Services
{
    public class TonKho_LoaiSvc
    {
        public static DsTonKho_Loai LayTonKho()
        {
            DsHoaDonNhap dsNhap = HoaDonNhapSvc.LayTatCaHoaDonNhap();
            DsHoaDonXuat dsXuat = HoaDonXuatSvc.LayTatCaHoaDonXuat();
            DsChungLoai dsChungLoai = ChungLoaiSvc.LayTatCaChungLoai();
            DsTonKho_Loai temp_ds = new DsTonKho_Loai();
            TonKho_Loai[] tonkho_arr = new TonKho_Loai[1];
            if (dsChungLoai.dsloai != null)
            {
                 tonkho_arr = new TonKho_Loai[dsChungLoai.dsloai.Length];
                for (int i = 0; i < dsChungLoai.dsloai.Length; i++)
                {
                    string tencl = dsChungLoai.dsloai[i].TenChungLoai;
                    string macl = dsChungLoai.dsloai[i].MaChungLoai;
                    float totalNhap = 0;
                    float totalXuat = 0;
                    float totalTon = 0;

                    if (dsNhap.HoaDon_arr != null)
                    {
                        for (int i2 = 0; i2 < dsNhap.HoaDon_arr.Length; i2++)
                        {
                            for (int i3 = 0; i3 < dsNhap.HoaDon_arr[i2].DsSp.DsSp.Length; i3++)
                            {
                                if (dsNhap.HoaDon_arr[i2].DsSp.DsSp[i3].LoaiSp.MaChungLoai == macl)
                                {
                                    totalNhap = dsNhap.HoaDon_arr[i2].DsSp.DsSp[i3].TonKho.SLNhap;
                                    totalTon = totalNhap;

                                }
                            }
                        }
                    }
                    
                    if (dsXuat.HoaDon_arr != null)
                    {
                        for (int i22 = 0; i22 < dsXuat.HoaDon_arr.Length; i22++)
                        {
                            for (int i3 = 0; i3 < dsXuat.HoaDon_arr[i22].DsSp.DsSp.Length; i3++)
                            {
                                if (dsXuat.HoaDon_arr[i22].DsSp.DsSp[i3].LoaiSp.MaChungLoai == macl)
                                {

                                    totalXuat += dsXuat.HoaDon_arr[i22].DsSp.DsSp[i3].TonKho.SLXuat;
                                    totalTon = totalNhap - totalXuat;

                                }
                            }
                        }
                    }

                    
                    tonkho_arr[i] = new TonKho_Loai
                    {
                        chungloai = new ChungLoai { TenChungLoai = tencl, MaChungLoai = macl },
                        SLnhap = totalNhap,
                        SLxuat = totalXuat,
                        Tonkho = totalTon
                    };

                }
                temp_ds.dsTonKho = tonkho_arr;
            } 
            
            
           
            return temp_ds;
        }
    }
}
