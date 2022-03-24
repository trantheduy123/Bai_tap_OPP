using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT3
{
    internal class triangle
    {
        // khai  bao can thiet
        private int ma;
        private int mb;
        private int mc;
        private string kieutamgiac;


        // constructor mac dinh 
        public triangle()
        {
           
        }

            public int getma() { return ma; }
            public int getmb() { return mb; }
            public int getmc() { return mc; }
            public void setma(int ma)
            {
            if (this.ma < 0) ma = 0;
            this.ma = ma; 
            }
            public void setmb(int mb) { if (this.mb < 0) mb = 0; this.mb = mb; }
            public void setmc(int mc) { if (this.mc < 0) mc = 0; this.mc = mc; }
        public triangle(int ma, int mb, int mc)
        {

            if ((ma < mb + mc) && (mb < ma + mc) && (mc < mb + ma))
            {
                setma(ma);
                setmb(mb);
                setmc(mc);
            }
            else ma = mb = mc = 0;
        }
            public int getchuvi()
        {
           return (ma + mb + mc)/2;
               
        }

        public int getdientich()
        {
            int P = (ma + mb + mc) / 2;
            return  (int)Math.Sqrt(P*(P - ma)*(P - mb)*(P - mc));    
                          
        }

        public void setthongtin()
        {
            if (ma == mb && mb == mc)
                kieutamgiac = "tam giac deu";
            if (ma == mb || mb == mc || mc == ma)
            {
                kieutamgiac = "tam giac can";
            }
            else
                kieutamgiac = "tam giac thuong";
        }

        public string getthongtin()
        {
            return kieutamgiac;
        }

        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} {3,-25} {4,-15} {5,-25}", getma(), getmb(), getmc(), getthongtin(), getchuvi(), getdientich());
        }

    }
}
