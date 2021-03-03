using System;
using System.Collections.Generic;
using System.Text;
using MathLib.Operations;

namespace MathLib.Functions
{
    static partial class Trigonometry
    {
        /// <summary>
        /// Calculates cosine of theta (x) using the Taylor series x^0 / 0! - x^2 / 2! + x^4 / 4! - x^6 / 6! ... 
        /// </summary>
        /// <param name="x">Theta, in radians</param>
        /// <param name="depth">The number of iterations through the series.</param>
        /// <returns>The sine of x in radians</returns>
        public static double Cosine(double x, int depth)
        {
            double total = 0;

            for (int n = 0; n < depth; n++)
            {
                int g = 2 * n;

                total += Math.Pow(-1, n) / g.Factorial() * Math.Pow(x, g);
            }

            return total;
        }
    }
}
