namespace Shapes___inlämning_TDD
{
    public interface IGeometricThing
    {
        /// <summary>
        /// Calculates the perimeter around the shape
        /// </summary>
        /// <returns>A float with the actual perimeter</returns>
        public float GetPerimeter();
        public float CalculateArea();
    }
}