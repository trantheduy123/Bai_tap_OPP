using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT3
{
    internal class vang : Class1
    {

        private string loaivang;
        private int thanhtien;
        public vang(string magiaodich, string ngaygiaodich, int dongia, int soluong, string loaivang) : base(magiaodich, ngaygiaodich, dongia, soluong)
        {
            this.loaivang = loaivang;
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
