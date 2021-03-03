using System;
using System.Collections.Generic;
using System.Text;
using MathLib.Operations;

namespace MathLib.Functions
{
    static partial class Derivations
    {
        public static double EulersNumber(int depth)
        {
            double total = 0;

            for (int i = 0; i < depth + 1; i++)
            {
                total += 1d / i.Factorial();
            }

            return total;
        }
    }
}
