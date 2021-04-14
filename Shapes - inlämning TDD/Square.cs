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

        internal float CalculateArea(Square square)
        {
            const float ToThePowerOf = 2.0f;

            if (square.Side < 0)
            {
                return 0;
            }
            return MathF.Pow(square.Side, ToThePowerOf);
        }
    }
}