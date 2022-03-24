using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT2
{
    class attributes
    {
        // khai bao thuoc tinh can thiet 
        private int maSV;
        private string tenSV;
        private float diemLT , diemTT;
        // khoi tao contrustor khong tham so

        public attributes() {


            maSV = 1;
            tenSV = "unknown";
            diemLT = 0;
            diemTT = 0;

        }

        // khoi tao contrustor co tham so
        public attributes(int maSV, string tenSV, float diemLT, float diemTT)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemLT = diemLT;
            this.diemTT = diemTT;
        }
        //----------- beginner getter and setter-----------
        public int getmaSV()
        {
            return maSV;
        }
        public void setmaSV(int maSV)
        {
            this.maSV=maSV;
        }
        public string gettenSV()
        {
            return tenSV;
        }
        public void settenSV(string tenSV)
        {
            this.tenSV=tenSV;
        }
        public float getdiemLT()
        {
            return diemLT;
        }
        public void setdiemLT(float diemLT)
        {
           if (diemTT >=0 && diemTT <= 10)
                this.diemLT = diemLT;
           else
                this.diemLT = 0;
        }
        public float getdiemTT() 
        { return diemTT; }
        public void setdiemTT(float diemTT)
        {
            if (diemTT >=0 && diemTT <=10)
                this.diemTT = diemTT;
            else
                this.diemTT = 0;
        }

        //----------- end getter and setter-----------
        //tao ham diem TB
        public float tinhdiemTB()
        {
            return (diemTT + diemLT) / 2;
        }

        public override string ToString()
        {
           return  $"(|{ this.maSV,-10}|{ this.tenSV,-25}|{ this.diemLT,-10}|{ this.diemTT,-10}|{ this.tinhdiemTB(),-10}| \n ";
        }
       

    }
}
