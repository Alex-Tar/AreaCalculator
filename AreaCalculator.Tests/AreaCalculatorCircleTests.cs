using System;
using AreaCalculator.Figures;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class AreaCalculatorCircleTests
    {
        /// <summary>
        /// Тестируем некорректный радиус круга
        /// </summary>
        [Test]
        public void CircleIncorrectRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1), Constants.CIRCLE_RADIUS_ERROR);
        }

        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [Test]
        public void CircleCalculateAreaTest()
        {
            // Arrange
            Circle circle = new Circle(5);
            double rightArea = Math.PI * Math.Pow(5, 2);

            // Act
            double circleArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(rightArea, circleArea);
        }
    }
}
