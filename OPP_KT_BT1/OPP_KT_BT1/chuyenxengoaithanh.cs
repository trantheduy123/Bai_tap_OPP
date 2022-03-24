using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT1
{
    internal class chuyenxengoaithanh : chuyenxe
    {
       
        private string noiden;
        private string songaydi;        
        private int doanhthu;

        public chuyenxengoaithanh(string masochuyen, string tentaixe, string soxe, string noiden, string songaydi, int doanhthu) : base(masochuyen,
                                                                                                                                        tentaixe,
                                                                                                                                        soxe,
                                                                                                                                        doanhthu)
        {
            this.noiden = noiden;
            this.songaydi = songaydi;
            this.doanhthu = doanhthu;
            getdoanhthu();
        }
      


    }
}
