using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal static class CircleCalculator
    {
        public static double GetCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius cannot be less or equal zero");
            }
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
