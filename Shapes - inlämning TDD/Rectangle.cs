using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes___inlämning_TDD
{
    class Rectangle : IGeometricThing
    {
        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }
        public float Height { get; set; }
        public float Width { get; set; }

        public float CalculateArea()
        {
            if (Height <= 0 || Width <= 0)
            {
                return 0;
            }

            return Height * Width;
        }

        public float GetPerimeter()
        {
            if (Height <= 0 || Width <= 0)
            {
                return 0;
            }

            return (Height * 2) + (Width * 2);
        }
    }
}
