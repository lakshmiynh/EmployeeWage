using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class monthwage
    {

        public void calmonthwage()
        {
            wage ob = new wage(20, 8);
            double onemonthwage = ob.onedaywage();
            Console.WriteLine(onemonthwage);
        }
    }
}
