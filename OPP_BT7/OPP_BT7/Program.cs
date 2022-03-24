using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT7
{
    internal class Program
    {
        private double dientich;
        private double chuvi;
        private double bankinh;
        static void Main(string[] args)
        {

            

           toado tam =new toado();

            Console.WriteLine("nhap toa do X tu ban phim");
            float x = int.Parse(Console.ReadLine());
            tam.setX(x);

            Console.WriteLine("nhap toa do Y tu ban phim");
            float y = int.Parse(Console.ReadLine()); 
            tam.setY(y);

            Console.WriteLine("nhap ten hinh tron");
            string name = Console.ReadLine();
            tam.setName(name);

            Console.WriteLine($" day la hinh tron co ten : {tam.getName()} ");
            Console.WriteLine($"hinh tron co tam : {tam.getX()} va {tam.getY()}");
            
            Program hinhtron = new Program();
            Console.WriteLine($"hinh tron co dien tich {hinhtron.getdientich()}");
            
            Console.WriteLine($"hinh tron co chu vi{hinhtron.getchuvi() }");
            
            

        }

        public void tinhdientich(double dientich, double bankinh)
        {
            this.dientich = dientich;
            this.bankinh = 10.5;
            dientich = (double)(bankinh * bankinh * 3.14);
        } 
        public double getdientich() { return dientich; }

        public void tinhchuvi(double chuvi, double bankinh)
        {
            this.chuvi = chuvi;
            this.bankinh = 10.5;
            chuvi = (double)(chuvi * bankinh * 2 * 3.14);
        }
        public double getchuvi() { return chuvi; }


    }
}
