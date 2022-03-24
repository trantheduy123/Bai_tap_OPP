using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT1
{
    internal class chuyenxenoithanh : chuyenxe
    {
        
        private string sotuyen;
        private int sokm;
        private int doanhthu;

        public chuyenxenoithanh(string masochuyen, string tentaixe, string soxe, string sotuyen, int sokm, int doanhthu) : base(masochuyen, tentaixe, soxe, doanhthu)
        {
            this.sokm = sokm;
            this.sotuyen = sotuyen;
            this.doanhthu = doanhthu;
            getdoanhthu();
        }
        
       
    }
}
