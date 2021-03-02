using System;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 0);

            Vector b = new Vector(0, 1, 0);

            Console.WriteLine(Vector.CrossProduct(a, b).Normalized);


            Console.WriteLine();
        }
    }
}
