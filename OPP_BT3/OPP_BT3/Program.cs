using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangle hinh1 = new triangle(5, 5, 5);
            triangle hinh2 = new triangle(3, 4, 5);
            triangle hinh3 = new triangle(9, 5, 4);
            triangle hinh4 = new triangle(1, 2, 5);
            triangle hinh5 = new triangle(3, 3, 4);

            hinh1.setthongtin();
            hinh2.setthongtin();
            hinh3.setthongtin();
            hinh4.setthongtin();
            hinh5.setthongtin();
            Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|{3,-15}|{4,-20}|{5,-20}|", "canh a", "canh b","canh c", "thong tin","chu vi "," dien tich");
            Console.WriteLine(hinh1.ToString());
            Console.WriteLine(hinh2.ToString());
            Console.WriteLine(hinh3.ToString());
            Console.WriteLine(hinh4.ToString());
            Console.WriteLine(hinh5.ToString());

        }
    }
}
