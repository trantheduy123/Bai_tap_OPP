using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT4
{
    internal class vehicle
    {
        // khai bao
        private string chuxe;
        private string loaixe;
        private int trigiaxe;
        private int dungtich;
        private int thuexe;
        // setget 

        public vehicle(string chuxe, string loaixe, int dungtich, int trigiaxe)
        {
            this.chuxe = chuxe;
            this.loaixe = loaixe;
            this.dungtich = dungtich;
            this.trigiaxe = trigiaxe;
        }

        public void settrigiaxe()
        {
            if (trigiaxe >= 0) 
                this.trigiaxe = trigiaxe;
            else 
                this.trigiaxe = 0;
        }
        public int gettrigiaxe()
        {
            return trigiaxe;
        }

        public void setdungtichxe()
        {
            if (dungtich >= 0)
                this.dungtich = dungtich;
            else 
                this.dungtich = 0;
        }

        public int getdungtichxe()
        {
            return dungtich;
        }

        public void setthuexe()
        {
            if ( dungtich <= 100)
            {
                thuexe =  trigiaxe * 1 / 100 ;
            }
            if (dungtich > 100 && dungtich <= 200)
            {
                thuexe = trigiaxe * 3 / 100;
            }
            if (dungtich > 200)
            {
                thuexe = trigiaxe * 5 / 100;
            }
            
        }
        public int getthuexe() 
        { return thuexe; }
         
        

        public override string ToString()
        {
            return string.Format("{0,-20} {1,-20} {2,-20} {3,-25} {4,-15}", chuxe, loaixe, getdungtichxe(), gettrigiaxe(), getthuexe());
        }



    }
}
