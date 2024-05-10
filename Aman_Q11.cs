﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //aman assignment

    internal class Aman_Q11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number 1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                int ans = num1 / num2;
                Console.WriteLine("ANSWER IS :" + ans);
            }
            catch (DivideByZeroException ex)
            { 
                Console.WriteLine("Cannot divide by zero" +ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Numeric value only"+ex.Message);
            }
            
        }
    }
}
