using NUnit.Framework;
using System;

namespace Shapes___inlämning_TDD
{
    [TestFixture]
    public class ShapeTests
    {
 
        [TestCase(5,25)]
        [TestCase(4, 16)]
        [TestCase(0.5f, 0.25f)]
        [TestCase(0.4f, 0.16f)]
        [TestCase(20.3f, 412.09f)]
        [TestCase(0.3f, 0.09f)]
        [TestCase(49.4f, 2440.36f)]
        [TestCase(2.3f, 5.29f)]
        [TestCase(0f, 0f)]
        [TestCase(-1f, 0f)]
        public void Square_CalculateArea_ReturnArea(float side, float expected)
        {
            //Arrange
            Square square = new Square(side);
            //Act
            var actual = square.CalculateArea(square);
            //Assert
            Assert.That(Math.Round(actual,4), Is.EqualTo(Math.Round(expected, 4)));
        }


        [TestCase(5,5, 25)]
        [TestCase(4,6, 24)]
        [TestCase(0.5f,1f, 0.5f)]
        [TestCase(0.4f,12, 4.8f)]
        [TestCase(0.0f, 12, 0)]
        [TestCase(-1, 0, 0)]
        [TestCase(-12, -12, 0)]
        public void Rectangle_CalculateArea_ReturnArea(float height, float width, float expected)
        {
            //Arrange
            Rectangle rectangle = new Rectangle(height,width);
            //Act
            var actual = rectangle.CalculateArea(rectangle);
            //Assert
            Assert.That(Math.Round(actual, 4), Is.EqualTo(Math.Round(expected, 4)));
        }
    }
}