using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngCalc.Service
{
    public class Geometric
    {
        public double Area(double width, double height)
        {
            return width * height;

        }
        public double Inercia(double width, double height)
        {
           return (width * Math.Pow(height,3)) / 12;
        }

        public double RigFlex(double inercia, double y)
        {
            return inercia / y;
        }
    }
}
