using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT4
{
    internal class giaodichnha : Class1
    {
        private int thanhtien;
        private string diachi;
        private string loainha;
        public giaodichnha(string magiaodich, string ngaygiaodich, int dongia, int dientich, string diachi, string loainha, int thanhtien = 0) : base(magiaodich, ngaygiaodich, dongia, dientich)
        {
            this.diachi = diachi;
            this.loainha = loainha;

            getthanhtien();
            this.thanhtien = thanhtien;
        }

        public void setthanhtien(int thanhtien)
        {

            if (loainha == "A")
            {

                this.thanhtien = (int)(getdientich() * getdongia());
            }
            else if (loainha == "B")
            {
                this.thanhtien = getdientich() * (getdongia() * 90) / 100;
            }
        }
        public int getthanhtien()
        {
            return this.thanhtien;
        }
    }
}
