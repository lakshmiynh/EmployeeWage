using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{


    internal class calmonthwage
    {
        public void monthwage()
        {
            Console.WriteLine("Enter how many days you worked");
            double days = Convert.ToDouble(Console.ReadLine());
            double onemonth = 20;
            wage obj = new wage(20, 8);
            double w = obj.onedaywage();

            if (days == onemonth)
            {
                double onemonthwage = w * days;
                Console.WriteLine(onemonthwage);
            }

        }
    }
}
