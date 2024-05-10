using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //aman assignment

    internal class Aman_Q6_Main
    {
        public static void Main(string[] args)
        {
            Excel1 excel1 = new Excel1();
            int num1 = 30;
            int num2 = 10;

            excel1.add(num1, num2);
            excel1.multiply(num1, num2);
            excel1.divide(num1, num2);
        }
    }
}
