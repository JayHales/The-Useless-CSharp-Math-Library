using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Operations
{
    static partial class Operations
    {
        public static double Factorial(this int a)
        {
            double total = 1;

            for (int i = 1; i < a + 1; i++)
            {
                total *= i;
            }

            return total;
        }
    }
}
