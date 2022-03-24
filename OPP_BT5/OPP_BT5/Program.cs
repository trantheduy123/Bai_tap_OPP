using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                hangthucpham hang1 = new hangthucpham("001", "Gao", 10000000, new DateTime(2018, 7, 10), new DateTime(2018, 7, 10));
                hang1.Kiemtra(hang1.getngaysanxuat(), hang1.getngayhethan());
                Console.WriteLine("Ma_Hang      Ten_Hang          Don_gia           NSX             NHH            Ghi chu  ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine(hang1.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Can not make this object!");
            }
        }
    }
}
