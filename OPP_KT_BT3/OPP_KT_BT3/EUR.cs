using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT3
{
    internal class EUR : Class1
    {
        private int tigia;
        private int thanhtien;
        public EUR(string magiaodich, string ngaygiaodich, int dongia, int soluong, int tigia) : base(magiaodich, ngaygiaodich, dongia, soluong)
        {
            this.tigia = tigia;
            getthanhtien();

        }
        public void settigia(int tigia)
        {
            if (this.tigia < 0) this.tigia = 0;
            else
                this.tigia = tigia;

        }
        public int gettigia()
        {
            return this.tigia;
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
            return this.thanhtien = getdongia() * getsoluong() * gettigia();
        }
    }
}
