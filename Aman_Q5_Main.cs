using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.IntrefaceSalQ5;

namespace Assignment
{
    //aman assignment

    public class Aman_Q5_Main
    {
        static void Main(string[] args)
        {
            TrainerSal trainer =new TrainerSal();
            ProjectManager project = new ProjectManager();
            float basicSal = 50000;
            Console.WriteLine("Trainer HRA :" + trainer.calchar(basicSal));
            Console.WriteLine("Trainer DA :"+trainer.calcda(basicSal));

            Console.WriteLine("Project manager HRA: " +project.calchar(basicSal) );
            Console.WriteLine("Project manager DA: " + project.calcda(basicSal));
        }
    }
}
