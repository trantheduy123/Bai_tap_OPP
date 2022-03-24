using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT8
{
    internal class Program
    {
        
        static void Main(string[] args, int choose)
        {
            List<Class1> CDlist = new List<Class1>();

            do
            {
                ShowMenu();
                switch (choose)
                {
                    case 1:
                        Input(CDlist);
                        break;
                    case 2:
                        Console.WriteLine("--------------Thong Tin CD-------------");
                        Console.WriteLine(String.Format("{0,-10} {1,-20} {2,-20} {3,-20}", "Ma CD", "Ten CD", "So bai hat", "Gia ban"));
                        Display(CDlist);
                        break;
                    case 3:
                        Class1 cd = new Class1();
                        cd.Input();
                        int Count = 0;
                        for (int i = 0; i < CDlist.Count; i++)
                        {
                            if (CDlist[i].getMaCD() == cd.getMaCD())
                            {
                                Count++;
                                Console.WriteLine("them vao khong thanh cong!!! Ma bi trung");
                            }
                        }
                        if (Count == 0) CDlist.Add(cd);
                        break;
                    case 4:
                        Console.WriteLine(" So luong CD trong List la: {0}", CDlist.Count);
                        break;

                    case 5:
                        tonggia(CDlist);
                        break;
                    case 6:
                        Class1 temp = CDlist[0];
                        for (int i = 0; i < CDlist.Count - 1; i++)
                        {
                            for (int j = 0; j < CDlist.Count; j++)
                            {
                                if (CDlist[i].getgiathanh() < CDlist[j].getgiathanh())
                                {
                                    temp = CDlist[j];
                                    CDlist[i] = CDlist[j];
                                    CDlist[i] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Sap xep thanh cong! Nhap so 2 de kiem tra!");
                        break;

                    case 7:
                        temp = CDlist[0];
                        for (int i = 0; i < CDlist.Count - 1; i++)
                        {
                            for (int j = 0; j < CDlist.Count; j++)
                            {
                                if (CDlist[i].getgiathanh() > CDlist[j].getgiathanh())
                                {
                                    temp = CDlist[j];
                                    CDlist[i] = CDlist[j];
                                    CDlist[i] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Sap xep thanh cong! Nhap so 2 de kiem tra!");
                        break;

                    case 8:
                        Console.WriteLine("Ket thuc!!!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai, Vui long nhap lai!");
                        break;
                }
            }
            while (choose != 8);

        }

        static void Input(List<Class1> CDlist)
        {
            Console.WriteLine("Nhap so luong can them vao danh sach");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Class1 cd = new Class1();
                cd.Input();
                CDlist.Add(cd);
            }
        }

        static void Display(List<Class1> CDlist)
        {
            for(int i = 0;i < CDlist.Count;i++)
            {
                CDlist[i].Display();
            }
        }

        static void tonggia(List<Class1> CDlist)
        {
            float sum = 0;
            for(int i = 0; i < CDlist.Count; i++)
            {
                sum += CDlist[i].getgiathanh();
            }
            Console.WriteLine("tong gia thanh cua cac CD:{0}", sum);

        }
        static void ShowMenu()
        {
            Console.WriteLine("1.\t Nhap thong tin n CD");
            Console.WriteLine("2.\t Hien thi thong tin vua nhap");
            Console.WriteLine("3.\t Them 1 CD vao danh sach va hien thi");
            Console.WriteLine("4.\t So luong CD co trong danh sach");
            Console.WriteLine("5.\t Tong gia thanh cua cac CD");
            Console.WriteLine("6.\t Sap xep danh sach giam dan theo gia thanh");
            Console.WriteLine("7.\t Sap xep danh sach tang dan theo ten CD");
            Console.WriteLine("8.\t Thoat");
            Console.WriteLine("Lua chon: ");
        }
    }
}
