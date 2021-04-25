namespace Shapes___inlämning_TDD
{
    public class GeoMetricCalculator
    {
        public float GetPerimeter(IGeometricThing[] shapes)
        {
            float result = 0f;
            if (shapes == null)
            {
                return result;
            }

            foreach (var shape in shapes)
            {
                if (shape == null)
                {
                    result += 0;
                    continue;
                }

                result += shape.GetPerimeter();
            }
            return result;
        }
    }
}