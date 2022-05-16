using KTLT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Services
{
    public class HetHSDSvc
    {
        public static DsSanpham LayDsHetHSD()
        {
            DsSanpham dsSp = SanPhamSvc.LayDsSanpham();
            DsSanpham new_ds = new DsSanpham();
            if (dsSp.DsSp != null)
            {
                new_ds.DsSp = new Sanpham[dsSp.DsSp.Length];
                DateTime current = DateTime.Now;
                int index = 0;
                for (int i = 0; i < dsSp.DsSp.Length; i++)
                {

                    if (dsSp.DsSp[i].HSD < current)
                    {
                        new_ds.DsSp[index] = dsSp.DsSp[i];
                        index++;
                    }
                }
            }
            

            return new_ds;
        }

    }
}
