using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //aman assignment
   public   abstract class AbstractclassQ6
    {
        public void add(int num1,int num2)
        {
            System.Console.WriteLine("the adition of {0} and {1} is {2}", num1, num2,(num1+num2));
        }
        abstract public void multi(int num1, int num2);
        abstract public void divide(int num1, int num2);

    }
    
    public class Excel1 : AbstractclassQ6
    {
        public  void add(int num1,int num2)
        {
            System.Console.WriteLine("the adition of {0} and {1} is {2}", num1, num2, (num1 + num2));

        }

        public override void multi(int num1,int num2)
        {
            Console.WriteLine("the multiply of {0} and {1} is {2}", (num1 * num2), num1, num2);
        }
        public override void divide(int num1,int num2)
        {
            Console.WriteLine("the divide of {0} and {1} is {2}", (num1 / num2), num1, num2);
        }
    }
}
