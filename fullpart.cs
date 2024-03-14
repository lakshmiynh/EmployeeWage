using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class fullpart
    {
        public void checkfulltmparttm()
        {
            Console.WriteLine("Enter the choice");
            Console.WriteLine("1.daily wage ");
            Console.WriteLine("2.parttime wage");


            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    if (choice == 1)
                    {
                        wage obj = new wage(20, 8);
                        double w = obj.onedaywage();
                        Console.WriteLine("daily wage" + w);
                    }

                    break;

                case 2:
                    if (choice == 2)

                    {
                        parttime obj1 = new parttime(8, 20);
                        double partw = obj1.addparttime();
                        Console.WriteLine(partw);
                    }
                    break;


            }

        }

    }
}
