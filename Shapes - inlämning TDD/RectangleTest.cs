#pragma warning disable S4144 // Methods should not have identical implementations
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Shapes___inlämning_TDD
{
    [TestFixture]
    class RectangleTest
    {
        [TestCase(5, 5, 25)]
        [TestCase(4, 6, 24)]
        [TestCase(0.5f, 1f, 0.5f)]
        [TestCase(0.4f, 12, 4.8f)]
        public void CalculateArea_PositiveValues_ReturnArea(
            float height,
            float width,
            float expected)
        {
            //Arrange
            Rectangle rectangle = new Rectangle(height, width);
            //Act
            var actual = rectangle.CalculateArea();
            //Assert
            Assert.That(Math.Round(actual, 4), Is.EqualTo(Math.Round(expected, 4)));
        }
                        
        [TestCase(0.0f, 12, 0)]
        [TestCase(-1, 0, 0)]
        [TestCase(-12, -12, 0)]
        public void CalculateArea_NegativeOrZeroValues_ReturnZero(
            float height,
            float width,
            float expected)
        {
            //Arrange
            Rectangle rectangle = new Rectangle(height, width);
            //Act
            var actual = rectangle.CalculateArea();
            //Assert
            Assert.That(Math.Round(actual, 4), Is.EqualTo(Math.Round(expected, 4)));
        }


        [TestCase(0, 5, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(5, 0, 0)]
        [TestCase(-1, 5, 0)]
        [TestCase(-10, -5, 0)]
        public void GetPerimiter_NegativeOrZeroValues_ReturnZero(
            float height,
            float width,
            float expected)
        {
            //Arrange
            Rectangle rectangle = new Rectangle(height, width);
            //Act
            var actual = rectangle.GetPerimiter();
            //Assert
            Assert.That
                (MathF.Round(actual, 4, MidpointRounding.ToEven),
                Is.EqualTo
                (Math.Round(expected, 4, MidpointRounding.ToEven)));
        }

        [TestCase(4, 5, 18)]
        [TestCase(10, 19, 58)]
        [TestCase(5, 5, 20)]
        [TestCase(1, 1, 4)]
        [TestCase(10, 10, 40)]
        public void GetPerimiter_PositiveValues_ReturnPerimiter(
            float height,
            float width,
            float expected)
        {
            //Arrange
            Rectangle rectangle = new Rectangle(height, width);
            //Act
            var actual = rectangle.GetPerimiter();
            //Assert
            Assert.That
                (MathF.Round(actual, 4, MidpointRounding.ToEven),
                Is.EqualTo
                (Math.Round(expected, 4, MidpointRounding.ToEven)));
        }
    }
}
#pragma warning restore S4144 // Methods should not have identical implementations