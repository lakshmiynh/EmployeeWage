using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class wage
    {
        double rupie;
        double hvr;
        public wage(double  rupie,double hvr)
        {
            this.rupie = rupie;
            this.hvr = hvr;
        }

        public double onedaywage()
        {

            return  hvr * rupie;
        }
    }
}
