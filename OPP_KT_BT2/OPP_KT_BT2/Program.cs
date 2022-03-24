using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sachcu sachcu = new sachcu("01", "3/2", 5000000, 23, "tran the duy ", "cu");

            Console.WriteLine("thanh tien sach cu ");

            Console.WriteLine(sachcu.getthanhtien());

            

        }
    }
}
