using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT8
{
    internal class Class1
    {
        private int MaCD;
        private string TuaCD;
        private int sobaihat;
        private int giathanh;

        public Class1(int maCD, string tuaCD, int sobaihat, int giathanh)
        {
            MaCD = 999999;
            TuaCD = "chua xac dinh";
            this.sobaihat = sobaihat;
            this.giathanh = giathanh;
        }

        public Class1()
        {
        }

        public void setMaCD(int MaCD)
        {
            if (MaCD > 0)
                this.MaCD = MaCD;
        }
        public int getMaCD()
        {
            return this.MaCD;
        }

        public void setTuaCD(string TuaCD)
        {
            if (!String.IsNullOrEmpty(TuaCD))
                this.TuaCD = TuaCD;
        }
        public string getTuaCD()
        {
            return TuaCD;
        }

        public void setsobaihat(int sobaihat)
        {
            if (sobaihat > 0)
                this.sobaihat = sobaihat;
        }
        public int getsobaihat() { return this.sobaihat; }

        public void setgiathanh(int giathanh)
        {
            if (giathanh > 0)
                this.giathanh = giathanh;
        }
        public int getgiathanh()
        {
            return giathanh;
        }

        public void Input()
        {
            Console.WriteLine("Ma CD: ");
            MaCD = int.Parse(Console.ReadLine());
            Console.WriteLine("Ten CD: ");
            TuaCD = Console.ReadLine();
            Console.WriteLine("So luong bai hat: ");
            sobaihat = int.Parse(Console.ReadLine());
            Console.WriteLine("Gia ban: ");
            giathanh = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine(string.Format("{0,-10} {1,-20} {2,-20} {3,-20}", MaCD, TuaCD, sobaihat, giathanh));

        }
    }
}
