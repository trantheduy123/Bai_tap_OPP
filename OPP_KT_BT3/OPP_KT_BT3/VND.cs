using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT3
{
    internal class VND : Class1
    {

        private int thanhtien;
        
        public VND(string magiaodich, string ngaygiaodich, int dongia, int soluong) : base(magiaodich, ngaygiaodich, dongia, soluong)
        {
            getthanhtien();
        }
        public void setthanhtien(int thanhtien)
        {
            if (thanhtien < 0)
            {
                this.thanhtien = 0;
            }
            else
                this.thanhtien = thanhtien;
        }

        public int getthanhtien()
        {
            return this.thanhtien = getdongia() * getsoluong();
        }

    }
}
