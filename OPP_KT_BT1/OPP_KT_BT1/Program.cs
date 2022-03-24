using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            chuyenxengoaithanh ngoaithanh1 = new chuyenxengoaithanh("001", "tran the duy", "01", "Ha noi", "2 ngay", 500000);
            chuyenxengoaithanh ngoaithanh2 = new chuyenxengoaithanh("002", "tran the duy", "02", "Ha noi", "2 ngay", 400000);
            chuyenxenoithanh noithanh1 = new chuyenxenoithanh("1", "tran the chau", "4", "chay 1 tuyen", 5, 123456);
            chuyenxenoithanh noithanh2 = new chuyenxenoithanh("2", "tran the chau", "2", "chay 2 tuyen", 3, 123123);

            // xe ngoai thanh

            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "doanh thu xe ngoai thanh ", "doanh thu xe noi thanh", " tong doanh thu");
            Console.WriteLine("{0,-20} {1,-20} {2,-20}",ngoaithanh1.getdoanhthu()+ ngoaithanh2.getdoanhthu(),noithanh1.getdoanhthu()+ noithanh2.getdoanhthu(), ngoaithanh1.getdoanhthu() + ngoaithanh2.getdoanhthu()+ noithanh1.getdoanhthu() + noithanh2.getdoanhthu());
        }
    }
}
