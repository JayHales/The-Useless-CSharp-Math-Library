using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    /// <summary>
    /// A 3 dimensional cartesian vector.
    /// </summary>
    class Vector
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public double z { get; private set; }

        public Vector(double x, double y, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// The magnitude of the vector. The length of the vector.
        /// 
        /// Found by square rooting the sum of the squares of the components.
        /// </summary>
        public double Magnitude {
            get 
            {
                return Math.Sqrt(
                    Math.Pow(x, 2) +     
                    Math.Pow(y, 2) +     
                    Math.Pow(z, 2)
                );
            }
        }

        /// <summary>
        /// The normalized vector. A normalized vector has a magnitude of 1. If the magnitude of the vector is equal to 0, then the normalized vector is equal to (0, 0, 0, 0). 
        /// 
        /// Found by dividing each component by the magnitude.
        /// </summary>
        public Vector Normalized
        {
            get
            {
                if (Magnitude == 0)
                    throw new Exception("Cannot normalize a vector with magnitude of 0");

                return new Vector(
                    x / Magnitude,
                    y / Magnitude,
                    z / Magnitude
                );
            }
        }

        /// <summary>
        /// Permanently normalizes the vector.
        /// 
        /// Found by dividing each component by the magnitude.
        /// </summary>
        public void Normalize()
        {
            if (Magnitude == 0)
            {
                x = 0;
                y = 0;
                z = 0;
            }

            x /= Magnitude;
            y /= Magnitude;
            z /= Magnitude;
        }

        /// <summary>
        /// Finds the dot product of two vectors.
        /// 
        /// The dot product is a scalar quantity comprised of the sum of the products of each component.
        /// 
        /// a · b = ax × bx + ay × by ... 
        /// 
        /// </summary>
        /// <param name="a">The first vector</param>
        /// <param name="b">The second vector</param>
        /// <returns>The dot product of the two vectors</returns>
        public static double DotProduct(Vector a, Vector b)
        {
            return
                a.x * b.x +
                a.y * b.y +
                a.z * b.z;            
        }

        /// <summary>
        /// Finds the cross product of two vectors.
        /// 
        /// The cross product is a vector which is perpendicular to the plane on which a and b are positioned.
        /// 
        /// cx = aybz − azby
        /// cy = azbx − axbz
        /// cz = axby − aybx
        /// </summary>
        /// <param name="a">The first vector</param>
        /// <param name="b">The second vector</param>
        /// <returns>The cross product of the two vectors.</returns>
        public static Vector CrossProduct(Vector a, Vector b)
        {
            return new Vector(
                a.y * b.z - a.z * b.y,
                a.z * b.x - a.x * b.z,
                a.x * b.y - a.y * b.x
            );
        }

        /// <summary>
        /// Finds the angle between two vectors. Found by taking the dot product and dividing it by the product of the two magnitudes. This effectively rearranges the dot product equation.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double AngleBetween(Vector a, Vector b)
        {
            double cosTheta = DotProduct(a, b) / (a.Magnitude * b.Magnitude);
            return Math.Acos(cosTheta);
        }
       
        public override string ToString() => $"({x}, {y}, {z})";
        public static Vector operator -(Vector a) => new Vector(-a.x, -a.y, -a.z);

        public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y, a.z + b.z);       
        public static Vector operator -(Vector a, Vector b) => a + -b;

        public static Vector operator *(Vector a, float b) => new Vector(a.x * b, a.y * b, a.z * b);
        public static Vector operator /(Vector a, float b) => a * (1 / b);

    }
}
