using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Employee
{
    internal class refactor
    {
        public void empattendance()
        {
            Console.WriteLine("check the employee attendace");
            attendance a = new attendance();
            a.empattendance();
        }

        public void dailywage()
        {
            Console.WriteLine("Enter your company salary for one hvr");
            double sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your company working hvr");
            double hvr = Convert.ToDouble(Console.ReadLine());

            wage ob = new wage(sal, hvr);
            ob.onedaywage();
        }

        public void partimewage()
        {
            Console.WriteLine("Enter your company salary for one hvr");
            double sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your company working hvr");
            double hvr = Convert.ToDouble(Console.ReadLine());

            parttime p = new parttime(sal, hvr);
            p.addparttime();

        }

        public void cal()
        {
            Console.WriteLine("calculate 1. fulltime wage and 2.partime wage ");
            fullpart c = new fullpart();
            c.checkfulltmparttm();
        }

        public void monthwayge()
        {
            Console.WriteLine("calculate monthly wages");
            monthwage m = new monthwage();
            m.calmonthwage();
        }

        public void calmonthsalary()
        {
            Console.WriteLine("calculate monthgly salary for your employe");
            calmonthwage cal = new calmonthwage();
            cal.monthwage();
        }

    }
}
