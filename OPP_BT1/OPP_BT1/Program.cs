using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = new constructorClass("cartesian",1,2);
            System.Console.WriteLine(A.ToString());
        }
    }
}
