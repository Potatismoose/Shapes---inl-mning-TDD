using System;

namespace Shapes___inlämning_TDD
{
    internal class Triangle
    {
        public Triangle(float baseMeasure, float heightMeasure)
        {
            Base = baseMeasure;
            Height = heightMeasure;
        }
        public float Height { get; set; }
        public float Base { get; set; }

        internal float CalculateArea()
        {
            if (Base <= 0 || Height <= 0)
            { 
                return 0;
            }

            return 0.5f * Base * Height;
        }

        internal float GetPerimiter()
        {
            if (Base <= 0 || Height <= 0)
            {
                return 0;
            }

            return Base * 3;
        }
    }
}