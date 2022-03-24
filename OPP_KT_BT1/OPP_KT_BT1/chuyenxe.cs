using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT1
{
    internal class chuyenxe
    {
        private string masochuyen;
        private string tentaixe;
        private string soxe;
        private int doanhthu;
        


        public chuyenxe(string masochuyen, string tentaixe, string soxe, int doanhthu)
        {
            this.masochuyen = masochuyen;
            this.tentaixe = tentaixe;
            this.soxe = soxe;
            this.doanhthu = doanhthu;
        }

        

        public void setdoanhthu(int doanhthu)
        {
            if (this.doanhthu >= 0)
            {
                this.doanhthu=doanhthu;
            }
            else
                this.doanhthu=0;
        }

        public int getdoanhthu()
        {
            return this.doanhthu;
        }
    }
}
