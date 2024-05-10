using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //aman assignment

    internal class IntrefaceSalQ5
    {
        interface Isalary
        {
            float calchar(float basic);
            float calcda(float basic);
        }
        public class TrainerSal : Isalary
        {
            public float calchar(float basic)
            {
                return basic * 0.1f; 
            }
            public float calcda(float basic)
            {
                return basic * 0.2f;
            }
        }
        public class ProjectManager : Isalary
        {
            public float calchar(float basic)
            {
                return basic * 0.1f;
            }
            public float calcda(float basic)
            {
                return basic * 0.12f;
            }
        }
    }
}
