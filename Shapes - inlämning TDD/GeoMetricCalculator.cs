using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes___inlämning_TDD
{
    class GeoMetricCalculator
    {

        public float GetPerimiter(IGeometricThing[] shapes)
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
