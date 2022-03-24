using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT11
{
    internal class Hocvien
    {
        private string hovaten { get; set; }
        private int namsinh { get; set; }
        private double diemtoan { get; set; }
        private double diemanhvan { get; set; }
        private double diemly { get; set; }
        private double diemhoa { get; set; }
        private double diemvan { get; set; }

        public Hocvien(string hovaten, int namsinh, double diemtoan, double diemanhvan, double diemly, double diemhoa, double diemvan)
        {
            this.hovaten = hovaten;
            this.namsinh = namsinh;
            this.diemtoan = diemtoan;
            this.diemanhvan = diemanhvan;
            this.diemly = diemly;
            this.diemhoa = diemhoa;
            this.diemvan = diemvan;
        }

        public double diemTB()
        {
            return (diemtoan + diemvan + diemanhvan + diemly + diemhoa) / 5;
        }

        public bool luanvan()
        {
            if (diemtoan > 5 && diemanhvan >5 && diemly >5 && diemhoa >5&& diemvan > 5)
            {
                if (diemTB() >  7)
                    return true;
            }
            return false;
        }

        public bool thitotnghiep()
        {
            if (diemtoan > 5 && diemanhvan > 5 && diemly > 5 && diemhoa > 5 && diemvan > 5)
            {
                if (diemTB() < 7)
                    return true;
            }
            return false;
        }
        public bool thilai()
        {
            if (diemtoan < 5 && diemanhvan < 5 && diemly < 5 && diemhoa < 5 && diemvan < 5)
            {
                    return true;
            }
            return false;
        }

    }
}
