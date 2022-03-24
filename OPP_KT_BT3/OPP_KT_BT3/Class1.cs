using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT3
{
    internal class Class1
    {
        private string magiaodich;
        private string ngaygiaodich;
        private int dongia;
        private int soluong;

        public Class1(string magiaodich, string ngaygiaodich, int dongia, int soluong)
        {
            this.magiaodich = magiaodich;
            this.ngaygiaodich = ngaygiaodich;
            this.dongia = dongia;
            this.soluong = soluong;
        }

        public void setdongia(int dongia)
        {
            if (dongia < 0) { this.dongia = 0; }
            this.dongia = dongia;
        }
        public int getdongia()
        {
            return this.dongia;
        }

        public void setsoluong(int soluong)
        {
            if (soluong < 0) { this.soluong = 0; }
            else 
                this.soluong = soluong;
        }

        public int getsoluong()
        {
            return this.soluong;
        }

       
    }
}
