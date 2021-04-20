using System;

namespace Shapes___inlämning_TDD
{
    internal class Square
    {
        public Square(float side)
        {
            Side = side;
        }

        public float Side { get; set; }

        public float CalculateArea()
        {
            const float ToThePowerOf = 2.0f;

            if (Side < 0)
            {
                return 0;
            }
            return MathF.Pow(Side, ToThePowerOf);
        }

        internal float GetPerimiter()
        {
            if (Side <= 0)
            {
                return 0;
            }

            return Side * 4;
        }
    }
}