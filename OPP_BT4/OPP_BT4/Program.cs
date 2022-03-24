using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle xe1 = new vehicle(" Nguyễn Thu Loan" ,"Future Neo", 90,3500000);
            vehicle xe2 = new vehicle(" Lê Minh Tính", "Ford Ranger", 3000, 12500000);
            vehicle xe3 = new vehicle(" Nguyễn Minh Triết", "Landscape", 1500, 10000000);
            xe1.setthuexe();
            xe2.setthuexe();
            xe3.setthuexe();
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-10}|", "Tên Chủ Xe ", "Loại Xe", "Dung Tích", "Trị Giá", "Thuế Phải Nộp");
            Console.WriteLine(xe1.ToString());
            Console.WriteLine(xe2.ToString());
            Console.WriteLine(xe3.ToString());
        }
    }
}
