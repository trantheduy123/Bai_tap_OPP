using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT5
{
    internal class hangthucpham
    {
        private string mahang;
        private string tenhang;
        private int dongia;
        DateTime ngaysanxuat;
        DateTime ngayhethan;
        private string ghichu;
        private string kq;
        public void Settenhang(string tenhang)
        {
            if (tenhang.Equals(""))
                this.tenhang = "xxx";
            else
                this.tenhang = tenhang;
        }

        public void Setdongia (int dongia)
        {
            if (this.dongia < 0) { this.dongia = 0; }
            else this.dongia = dongia;
        }

        public void Setngaysanxuat(DateTime ngaysanxuat)
        {
            int result = DateTime.Compare(this.ngaysanxuat,DateTime.Now);
            if ( result < 0)
            {
                this.ngaysanxuat = DateTime.Now;

            }
            else 
                this.ngaysanxuat=ngaysanxuat;
        }
        public void Setngayhethan(DateTime ngayhethan)
        {
            int result = DateTime.Compare(this.ngayhethan,this.ngaysanxuat);
            if ( result < 0)
            {
                this.ngayhethan = ngaysanxuat;

            }
            else 
                this.ngayhethan=ngayhethan;
        }

        public string getmahang()
        {
            return this.mahang;
        }
        public string gettenhang() { return this.tenhang; }

        public int getdongia() { return this.dongia; }
        public DateTime getngaysanxuat() { return this.ngaysanxuat; }
        public DateTime getngayhethan() { return this.ngayhethan; }

        public hangthucpham(string mahang , string tenhang , int dongia , DateTime ngaysanxuat , DateTime ngayhethan)
        {
            if (mahang.Equals("")) throw new Exception("fail required!");
            else
            {
                this.mahang = mahang;
                this.tenhang = tenhang;
                this.dongia = dongia;
                Setngaysanxuat(ngaysanxuat);
                Setngayhethan(ngayhethan);
            }
        }

        public void Kiemtra( DateTime ngaysanxuat , DateTime ngayhethan)
        {
            int result = DateTime.Compare(ngaysanxuat, ngayhethan);
            if (result < 0)
                kq = "con han";
            else kq = " het han";
        }

        public string getghichu() { return kq ; }
        public override string ToString()
        {
            return string.Format("{0,-13} {1,-16} {2,-18:0,0}{3,-15:d}{4,-16:d}{5}", getmahang(), gettenhang(), getdongia(), getngaysanxuat(), getngayhethan(), getghichu());
        }

    }

}
