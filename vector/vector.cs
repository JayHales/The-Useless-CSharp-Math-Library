using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    class Vector
    {
        public float x { get; private set; }
        public float y { get; private set; }
        public float z { get; private set; }
        public float w { get; private set; }

        public Vector(float x, float y, float z = 0, float w = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public float Magnitude {
            get 
            {
                return (float)Math.Sqrt(
                    Math.Pow(x, 2) +     
                    Math.Pow(y, 2) +     
                    Math.Pow(z, 2) +     
                    Math.Pow(w, 2)
                );
            }
        }

        public Vector Normalized
        {
            get
            {
                if (Magnitude == 0)
                    return new Vector(0, 0);

                return new Vector(
                    x / Magnitude,
                    y / Magnitude,
                    z / Magnitude,
                    w / Magnitude
                );
            }
        }
    }
}
