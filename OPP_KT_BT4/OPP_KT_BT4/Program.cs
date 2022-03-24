
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            giaodichdat giaodichdat1 = new giaodichdat("01", "8/3", 500, 200, "A");
            giaodichdat giaodichdat2 = new giaodichdat("01", "8/3", 500, 200, "B");
            giaodichdat giaodichdat3 = new giaodichdat("01", "8/3", 500, 200, "C");
            giaodichnha giaodichnha1 = new giaodichnha("02", "15/8", 100, 300, "356 go dau", "A");

            Console.WriteLine("tong thanh tien giao dich dat");
            Console.WriteLine(giaodichdat1.getthanhtien()+giaodichdat2.getthanhtien()+giaodichdat3.getthanhtien());
            Console.WriteLine("trung binh giao dich dat");
            Console.WriteLine((giaodichdat1.getthanhtien() + giaodichdat2.getthanhtien() + giaodichdat3.getthanhtien())/3);
            Console.WriteLine("tong giao dich nha thang ");
            Console.WriteLine(giaodichnha1.getthanhtien());

        }
    }
}
