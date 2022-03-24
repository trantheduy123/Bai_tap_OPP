using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT9
{
    internal class Congnhan
    {
        private string maCN { get; set; }
        private string mH { get; set; }
        private string mTen { get; set; }
        protected double soSP;
        protected double luongnv;

        public Congnhan(string maCN, string mH, string mTen, double soSP, double luongnv)
        {
            this.maCN = maCN;
            this.mH = mH;
            this.mTen = mTen;
            this.soSP = soSP;
            this.luongnv = luongnv;
        }

       

        public void setsoSP(double soSP)
        {
            if (soSP > 0) this.soSP = soSP;
        }
        public double getsoSP()
        {
            return soSP;
        }

        public Congnhan() { }
        
        public double Tinhluongnv(double luongnv)
        {
            if (this.soSP > 1 && this.soSP <= 200)
            {
                return this.luongnv = this.soSP * 0.5;
            }
            else if (this.soSP > 200 && (this.soSP <= 399))
            {
                return this.luongnv = this.soSP * 0.55;
            }
            else if (this.soSP > 400 && this.soSP <= 599)
            {
                return this.luongnv = this.soSP * 0.6;
            }
            else
                return this.luongnv = this.soSP * 0.65;
        }

        public void setInput()
        {
            Console.WriteLine("Ma CN :");
            maCN = Console.ReadLine();
            Console.WriteLine("Ho CN :");
            mH = Console.ReadLine();
            Console.WriteLine("Ten CN :");
            mTen = Console.ReadLine();
            Console.WriteLine("so san pham");
            soSP = int.Parse(Console.ReadLine());
        }

       public string toString()
        {
            return string.Format("{0,-10}{1,-10}{2,-10}{3,-10}{4}", this.maCN, this.mH, this.mTen, this.soSP, this.luongnv);
        } 
    }
}
