using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //aman assignment

    internal class Aman_Q10_delegate
    {
        delegate int mydel();
        delegate int yourdel(int num);
        public static int greet()
        {
            Console.WriteLine("Hello");
            return 0;
        }
        public static int merrychristmas()
        {
            Console.WriteLine("Happy christmas");  
            return 0;
        }
        public static int odd(int num)
        {
            return num;
        }
        public static int even(int num)
        {
            return num;
        }

        static void Main()
        {
            mydel del;
            Console.WriteLine("MerryChristmas or greeting card");
            string choice =Console.ReadLine();
            choice=choice.ToUpper();
            if(choice == "GREET")
            {
                del = new mydel(greet);
            }
            else
            {
                del = new mydel(merrychristmas);
            }
            del();

            yourdel yourDelegate;
            Console.WriteLine("enter a number:");
            int choices= Convert.ToInt32(Console.ReadLine());
            if(choices % 2 == 0)
            {
                yourDelegate=new yourdel(even);
                int ans = yourDelegate(choices);

                Console.WriteLine(ans + "is even number");


            }
            else
             {
                yourDelegate = new yourdel(odd);
                Console.WriteLine("odd");
                int ans = yourDelegate(choices);
                Console.WriteLine(ans + "is odd number");
            }
        }


    }

}
