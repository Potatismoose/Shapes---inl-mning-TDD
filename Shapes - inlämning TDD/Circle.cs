using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes___inlämning_TDD
{
    class Circle : IGeometricThing
    {
        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Radius { get; set; }

        public float CalculateArea()
        {
            if (Radius <= 0)
            {
                return 0;
            }

            return MathF.PI * (MathF.Pow(Radius, 2));
        }

        public float GetPerimeter()
        {
            if (Radius <= 0)
            {
                return 0;
            }

            return MathF.PI * 2 * Radius;
        }
    }
}
