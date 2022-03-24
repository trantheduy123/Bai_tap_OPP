using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT4
{
    internal class giaodichdat : Class1
    {
        private string loaidat;
        private int thanhtien;
        public giaodichdat(string magiaodich, string ngaygiaodich, int dongia, int dientich ,string loaidat) : base(magiaodich, ngaygiaodich, dongia, dientich)
        {
            this.loaidat = loaidat;
            getthanhtien();
        }


        public void setthanhtien(int thanhtien)
        {
            
            switch (loaidat)
            {
                case "A":
                    thanhtien = (int)(getdientich() * getdongia() * 1.5);
                    break;
                case "B":
                    thanhtien = getdientich() * getdongia();
                    break;
                case "C":
                    thanhtien = getdientich() * getdongia();
                    break;
            }
        }
        public int getthanhtien()
        {
            return this.thanhtien;
        }


       

    }
}
