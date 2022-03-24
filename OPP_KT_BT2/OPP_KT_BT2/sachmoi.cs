using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT2
{
    internal class sachmoi : sachclass
    {
        
        private int thanhtien;
        public sachmoi(string masach, string ngaynhap, int dongia, int soluong, string nhaxuatban, string tinhtrang, int thanhtien) : base(masach, ngaynhap, dongia, soluong, nhaxuatban, tinhtrang, thanhtien)
        {
            
            getthanhtien();
        }

        public sachmoi(string masach, string ngaynhap, int dongia, int soluong, string nhaxuatban, string tinhtrang) : base(masach, ngaynhap, dongia, soluong, nhaxuatban, tinhtrang)
        {
        }

        public void setthanhtien(int thanhtien)
        {
            if (thanhtien < 0) this.thanhtien = 0;
            else
                this.thanhtien = thanhtien;
        }

        public int getthanhtien()
        {
            return this.thanhtien = getsoluong() * getdongia();
        }
    }
}
