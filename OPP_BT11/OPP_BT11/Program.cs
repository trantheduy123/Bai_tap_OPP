using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Hocvien> hocViens = new List<Hocvien>();
            int soluongLamLuanVan = 0, soluongThiTotNghiep = 0, soluongThiLai = 0;
            Hocvien HV1 = new Hocvien("Le Hai Duong", 1999, 9, 7.5, 8.5, 7, 7.5);
            Hocvien HV2 = new Hocvien("Nguyen Hoang Viet", 2003, 8, 8, 7, 9.5, 9);
            Hocvien HV3 = new Hocvien("Luu Khoa Hoc", 2003, 8.5, 7, 8.5, 6.5, 7);
            Hocvien HV4 = new Hocvien("Huynh Hung Thinh", 2000, 6.5, 6, 7, 5, 5);
            Hocvien HV5 = new Hocvien("Truong Tat Sang", 1999, 4, 5, 7, 8, 9);
            hocViens.Add(HV1);
            hocViens.Add(HV2);
            hocViens.Add(HV3);
            hocViens.Add(HV4);
            hocViens.Add(HV5);
            for(int i = 0; i < hocViens.Count; i++)
            {
                if (hocViens[i].luanvan() == true) soluongLamLuanVan++;
                else if (hocViens[i].thitotnghiep() == true) soluongThiTotNghiep++;
                else if (hocViens[i].thilai() == true) soluongThiLai++;
            }
            Console.WriteLine("Số lượng học viên làm luận văn = " + soluongLamLuanVan);
            Console.WriteLine("Số lượng học viên thi tốt nghiệp = " + soluongThiTotNghiep);
            Console.WriteLine("Số lượng học viên thi lại = " + soluongThiLai);
        }
    }
}
