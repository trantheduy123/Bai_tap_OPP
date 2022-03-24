using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vang vang = new vang("01", "2/5", 5000000, 50, "vangtrang");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", "ma giao dich", "ngay giao dich", "don gia", "so luong", "loai vang");          
            Console.WriteLine("tien cua vang la");
            Console.WriteLine(vang.getthanhtien());

            USD usd = new USD("01", "2/5", 100000000, 50, 2);
            Console.WriteLine("thanh tien cua usd la");
            Console.WriteLine(usd.getthanhtien());

            EUR eur = new EUR("01", "2/5", 100000000, 50, 2);
            Console.WriteLine("thanh tien cua eur la");
            Console.WriteLine(eur.getthanhtien());

            VND vnd = new VND("01", "2/5", 100000000, 50);
            Console.WriteLine("thanh tien cua vnd la");
            Console.WriteLine(vnd.getthanhtien());

            Console.WriteLine("trung binh thanh tien cua cac loai tien te la");
            Console.WriteLine((usd.getthanhtien()+eur.getthanhtien()+vnd.getthanhtien())/3);

            
        }
    }
}
