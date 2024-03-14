using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class parttime


    {
        double phvr;
        double amt;
        public parttime(double phvr, double amt)
        {
            this.phvr = phvr;
            this.amt = amt;
        }
        public double addparttime()
        {

            return amt * phvr;

        }
    }
}
