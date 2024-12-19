using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal static class TriangleCalculator
    {
        internal static double GetTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            CheckTriangleCorrectness(firstSide, secondSide, thirdSide);
            double p = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }

        internal static bool CheckIsTriangleRight(double firstSide, double secondSide, double thirdSide)
        {
            CheckTriangleCorrectness(firstSide, secondSide, thirdSide);

            double[] sides = {firstSide, secondSide, thirdSide};
            Array.Sort(sides);

            if (Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))
            {
                return true;
            }
            return false;
        }

        private static void CheckTriangleCorrectness(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("One or more sides less or equal to zero");
            }
            if (firstSide + secondSide <= thirdSide)
            {
                throw new ArgumentException($"There is no such triangle {firstSide} + {secondSide} <= {thirdSide}");
            }
            if (secondSide + thirdSide <= firstSide)
            {
                throw new ArgumentException($"There is no such triangle {secondSide} + {thirdSide} <= {firstSide}");
            }
            if (thirdSide + firstSide <= secondSide)
            {
                throw new ArgumentException($"There is no such triangle {thirdSide} + {firstSide} <= {secondSide}");
            }
        }

    }
}
