using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT4
{
    internal class Class1
    {
        private string magiaodich;
        private string ngaygiaodich;
        private int dongia;
        private int dientich;

        public Class1(string magiaodich, string ngaygiaodich, int dongia, int dientich)
        {
            this.magiaodich = magiaodich;
            this.ngaygiaodich = ngaygiaodich;
            this.dongia = dongia;
            this.dientich = dientich;
        }
        public void setdongia(int dongia)
        {
            if (dongia < 0) this.dongia = 0;
            else
                this.dongia = dongia;

        }
        public int getdongia()
        {
            return dongia;
        }

        public void setdientich(int dientich)
        {
            if (dientich <0) this.dientich = 0;
            else
                this.dientich=dientich;
        }
        public int getdientich()
        {
            return dientich;
        }
    }
}
