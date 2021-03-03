using System;
using System.Collections.Generic;
using System.Text;
using MathLib.Operations;

namespace MathLib.Functions
{
    static partial class Trigonometry
    {

        /// <summary>
        /// Calculates sine of theta (x) using the Taylor series x^1 / 1! - x^3 / 3! + x^5 / 5! - x^7 / 7! ... 
        /// </summary>
        /// <param name="x">Theta</param>
        /// <param name="depth">The number of iterations through the series.</param>
        /// <returns></returns>
        public static double Sine(double x, int depth)
        {
            double total = 0;

            for (int n = 0; n < depth; n++)
            {
                int g = (2 * n) + 1;

                total += Math.Pow(-1, n) / g.Factorial() * Math.Pow(x, g);
            }

            return total;
        }
    }
}
