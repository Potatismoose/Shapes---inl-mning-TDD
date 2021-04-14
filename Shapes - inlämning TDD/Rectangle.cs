using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes___inlämning_TDD
{
    class Rectangle
    {
        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }
        public float Height { get; set; }
        public float Width { get; set; }

        internal float CalculateArea(Rectangle rectangle)
        {
            if (rectangle.Height < 0 || rectangle.Width < 0)
            {
                return 0;
            }

            return rectangle.Height * rectangle.Width;
        }
    }
}
