using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_KT_BT2
{
    internal class sachclass
    {
        private string masach;
        private string ngaynhap;
        private int dongia;
        private int soluong;
        private string nhaxuatban;
        private string tinhtrang;
        
        public sachclass(string masach, string ngaynhap, int dongia, int soluong, string nhaxuatban, string tinhtrang, int thanhtien)
        {
            this.masach = masach;
            this.ngaynhap = ngaynhap;
            this.dongia = dongia;
            this.soluong = soluong;
            this.nhaxuatban = nhaxuatban;
            this.tinhtrang = tinhtrang;
            
        }

        public sachclass(string masach, string ngaynhap, int dongia, int soluong, string nhaxuatban, string tinhtrang)
        {
            this.masach = masach;
            this.ngaynhap = ngaynhap;
            this.dongia = dongia;
            this.soluong = soluong;
            this.nhaxuatban = nhaxuatban;
            this.tinhtrang = tinhtrang;
        }

        public void setdongia(int dongia)
        {
            if (dongia < 0) { dongia = 0; }
            else 
                this.dongia = dongia;
        }
        public int getdongia()
        {
            return dongia;
        }

        public void setsoluong(int soluong)
        {
            if (soluong < 0) { soluong = 0; }
            else
                this.soluong = soluong;
        }
        public int getsoluong()
        {
            return soluong;
        }

       
        
    }

}
