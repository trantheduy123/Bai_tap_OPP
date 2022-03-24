using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT2
{
    internal class sachgiaokhoa : sachclass
    {
        private int thanhtien;
        
        private int thue;

        public sachgiaokhoa(string masach, string ngaynhap, int dongia, int soluong, string nhaxuatban, string tinhtrang, int thanhtien) : base(masach, ngaynhap, dongia, soluong, nhaxuatban, tinhtrang, thanhtien)
        {
            this.thanhtien = thanhtien;
            

           getthanhtien();

        }

        public void setthue(int thue)
        {
            if (thue < 0) { this.thue = 0; }
            else { this.thue = thue; }
        }

        public int getthue()
        {
            return thue;
        }

        public void setthanhtien(int thanhtien)
        {
            if (thanhtien < 0) this.thanhtien = 0;
            else
                this.thanhtien = thanhtien;
        }

        public int getthanhtien()
        {
            return this.thanhtien = getsoluong() * (getdongia() + getthue());
        }
    }
}
