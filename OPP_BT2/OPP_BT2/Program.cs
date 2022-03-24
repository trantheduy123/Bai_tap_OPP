using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // tao SV 1 chua thong tin cua minh
            //--------------SV1----------------
            attributes SV1 =new attributes();
            
            SV1.setmaSV(123456);
            SV1.settenSV("Tran The Duy");
            SV1.setdiemLT((float)9.8);
            SV1.setdiemTT((float)9.9);

            // tao SV 2 chua thong tin cua ban than
            //--------------SV2----------------
           attributes SV2 = new attributes();
            SV2.setmaSV(5555555);
            SV2.settenSV("Tran Vien Toan");
            SV2.setdiemLT((float)9.0);
            SV2.setdiemTT((float)7.5);

            // tao SV 3 nhap thong tin tu ban phim
            //--------------SV3----------------
           attributes SV3 = new attributes();
            Console.WriteLine("mời nhập thông tin SV3");
           Console.WriteLine("Nhập mã số sinh viên 3 ");
           SV3.setmaSV(int.Parse(Console.ReadLine()));
           Console.WriteLine("Nhập họ và tên sinh viên 3");
           SV3.settenSV(Console.ReadLine());
           Console.WriteLine("Nhập điểm TT sinh viên 3");
            SV3.setdiemTT(float.Parse(Console.ReadLine()));
            Console.WriteLine("Nhập điểm LT sinh viên 3");
           SV3.setdiemLT(float.Parse(Console.ReadLine()));

            

            // in theo format
            Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|", "masv","hoten", "diemlt", "diemth", "diemtb");
             Console.Write(SV1.ToString());
            Console.Write(SV2.ToString());
            Console.Write(SV3.ToString());
        }
       
     
    }
}
