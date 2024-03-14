using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class attendance
    {
        public void empattendance()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2); // Generates either 0 or 1 (0 for absent, 1 for present)

            if (randomNumber == 1)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
