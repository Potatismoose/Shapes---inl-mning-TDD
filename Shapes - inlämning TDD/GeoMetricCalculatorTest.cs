using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Shapes___inlämning_TDD
{
    [TestFixture]
    internal class GeoMetricCalculatorTest
    {
        [Test]
        public void GetPerimiter_ArrayWithValidShapes_ReturnTotalPerimiter()
        {
            //Arrange
            var expected = 132.28f;
            var geoThings = new IGeometricThing[]
                {
                new Triangle(10, 8.660254037f),
                new Square(15),
                new Rectangle(8,10),
                new Circle(1)
                };

            GeoMetricCalculator geoCalc = new();
            //Act
            var actual = geoCalc.GetPerimiter(geoThings);
            //Assert
            Assert.That(MathF.Round(actual,2), Is.EqualTo(MathF.Round(expected, 2)));
        }

        [Test]
        public void GetPerimiter_ArrayContainingNullObjects_ReturnZero()
        {
            //Arrange
            var expected = 0f;
            var geoThings = new IGeometricThing[4];
            GeoMetricCalculator geoCalc = new();
            //Act
            var actual = geoCalc.GetPerimiter(geoThings);
            //Assert
            Assert.That(MathF.Round(actual, 2), Is.EqualTo(MathF.Round(expected, 2)));
        }

        [Test]
        public void GetPerimiter_NullArray_ReturnZero()
        {
            //Arrange
            const float expected = 0f;
            GeoMetricCalculator geoCalc = new();
            //Act
            var actual = geoCalc.GetPerimiter(null);
            //Assert
            Assert.That(MathF.Round(actual, 2), Is.EqualTo(MathF.Round(expected, 2)));
        }
    }
}