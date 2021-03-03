using System;
using MathLib.Functions;
using MathLib.Vectors;
using MathLib.Operations;
namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 0);

            Vector b = new Vector(0, 1, 0);

            Console.WriteLine(Trigonometry.Sine(Math.PI / 2d, 35));

        }
    }
}
