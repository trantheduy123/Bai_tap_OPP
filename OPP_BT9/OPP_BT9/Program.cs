using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT9
{
    internal class danhsachcongnhan
    {
        static void Main(string[] args)
        {
            List<Congnhan> congnhanlist = new List<Congnhan>();
            int choice;
            do
            {
                Showmenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Input(congnhanlist); break;
                    case 2:
                        Congnhan CN = new Congnhan();
                        CN.setInput();
                        int count = 0;
                        for (int i = 0; i < congnhanlist.Count; i++)
                        {
                            if (congnhanlist[i] != CN) { count++; }
                            else if (count == 0) congnhanlist.Add(CN); break;

                        }
                        break;
                    case 3:
                        Console.WriteLine(string.Format("{0,-10}{1,-10}{2,-10}{3,-10}{4}", "maCN", "mH", "mTen", "soSP", "luongnv"));
                        display(congnhanlist);
                        break;
                    case 4:
                        Console.WriteLine(" So luong Cong Nhan trong List la: {0}", congnhanlist.Count); break;
                    case 5:
                        Console.WriteLine("Danh Sach Cong Nhan lam tren 200 san pham: ");
                        for (int i = 0; i < congnhanlist.Count; i++)
                        {
                            if ((congnhanlist[i].getsoSP() > 200))
                            {
                                Console.WriteLine(congnhanlist[i].toString());
                            }
                        }
                        break;
                    case 6:
                        Congnhan temp = congnhanlist[0];
                        for (int i = 0; i < congnhanlist.Count - 1; i++)
                        {
                            for (int j = 0; j < congnhanlist.Count; j++)
                            {
                                if (congnhanlist[i].getsoSP() < congnhanlist[j].getsoSP())
                                {
                                    temp = congnhanlist[j];
                                    congnhanlist[j] = congnhanlist[i];
                                    congnhanlist[i] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Danh Sach sau khi duoc sap xep thanh cong: ");
                        display(congnhanlist);
                        break;


                }

            }
            while (choice != 7);


        }
        static void Showmenu()
        {
            Console.WriteLine("1. \t tao danh sach cong nhan");
            Console.WriteLine("2. \t them cong nhan vao danh sach");
            Console.WriteLine("3. \t xuat toan bo thong tin cong nhan");
            Console.WriteLine("4. \t tinh so luong cong nhan vien co trong danh sach");
            Console.WriteLine("5. \t xuat thong thin cong nhan tren 200 sp");
            Console.WriteLine("6. \t sap xep cong nhan theo san pham giam dan");
            Console.WriteLine("7. \t thoat ra");
            Console.WriteLine("Lua chon: ");
        }
        static void Input(List<Congnhan> congnhanlist)
        {

            Console.WriteLine("nhap so luong can them vao danh sach ");
            int socongnhan = int.Parse(Console.ReadLine());
            for (int i = 0; i < socongnhan; i++)
            {
                Congnhan congnhan = new Congnhan();
                congnhan.setInput();
                congnhanlist.Add(congnhan);
            }
        }

        static void display(List<Congnhan> congnhalist)
        {
            for (int i = 0; i < congnhalist.Count; i++)
            {
                Console.WriteLine(congnhalist[i].toString());
            }
        }

    }
}
    

