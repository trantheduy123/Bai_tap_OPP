using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT7
{
    internal class toado
    {
        private float x;
        private float y;
        private string name;

        public void setX(float x)
        {
            this.x = x;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public float getX()
        {
            return x;
        }

        public float getY()
        {
            return y;
        }

        public string getName()
        {
            return name;
        }



        public string ToStringForm()
        {
            return $"({this.x}, {this.x}) ";

        }

        public toado()
        {
            this.x = default;
            this.y = default;
            this.name = default;
        }

    }
}
