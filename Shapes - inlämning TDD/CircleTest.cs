#pragma warning disable S4144 // Methods should not have identical implementations
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace Shapes___inlämning_TDD
{
    [TestFixture]
    class CircleTest
    {
        [TestCase(1, 3.1416f)]
        [TestCase(5, 78.5398f)]
        public void CalculateArea_PositiveValues_ReturnArea(
            float radius,
            float expected)
        {
            //Arrange
            Circle circle = new Circle(radius);
            //Act
            var actual = circle.CalculateArea();
            //Assert
            Assert.That
                (Math.Round(actual, 4, MidpointRounding.ToEven),
                Is.EqualTo
                (Math.Round(expected, 4, MidpointRounding.ToEven)));
        }

        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(-100, 0)]

        public void CalculateArea_NegativeOrZeroValues_ReturnZero(

            float radius,
            float expected)
        {
            //Arrange
            Circle circle = new Circle(radius);
            //Act
            var actual = circle.CalculateArea();
            //Assert
            Assert.That
                (Math.Round(actual, 4, MidpointRounding.ToEven),
                Is.EqualTo
                (Math.Round(expected, 4, MidpointRounding.ToEven)));
        }



        [TestCase(1, 6.28f)]
        [TestCase(5, 31.42f)]
        public void GetPerimiter_PositiveValues_ReturnArea(
            float radius,
            float expected)
        {
            //Arrange
            Circle circle = new Circle(radius);
            //Act
            var actual = circle.GetPerimiter();
            //Assert
            Assert.That
                (MathF.Round(actual, 2, MidpointRounding.ToEven),
                Is.EqualTo
                (MathF.Round(expected, 2, MidpointRounding.ToEven)));
        }

        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(-100, 0)]

        public void GetPerimiter_NegativeOrZeroValues_ReturnZero(

            float radius,
            float expected)
        {
            //Arrange
            Circle circle = new Circle(radius);
            //Act
            var actual = circle.GetPerimiter();
            //Assert
            Assert.That
                (MathF.Round(actual, 2, MidpointRounding.ToEven),
                Is.EqualTo
                (MathF.Round(expected, 2, MidpointRounding.ToEven)));
        }


    }
}
#pragma warning restore S4144 // Methods should not have identical implementations