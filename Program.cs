using System;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vec = new Vector(1, 2);

            Console.WriteLine(vec.Magnitude);

            Console.WriteLine(vec.Normalized.Magnitude);
        }
    }
}
