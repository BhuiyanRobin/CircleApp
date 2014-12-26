using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public double radious;

        public double GetArea()
        {
            return 3.1416*radious*radious;
        }
        public double GetPeremeter()
        {
            return 2 * 3.1416 * radious;

        }
        public double GetDiameter()
        {
            return 2*radious;
        }
        


    }

}
