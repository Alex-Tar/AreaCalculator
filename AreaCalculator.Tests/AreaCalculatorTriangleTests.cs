using System;
using AreaCalculator.Figures;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class AreaCalculatorTriangleTests
    {                   
        /// <summary>
        /// Тестируем некорректные длины сторон треугольника
        /// </summary>
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5), Constants.TRIANGLE_SIDE_ERROR);
            Assert.Throws<ArgumentException>(() => new Triangle(3, -4, 5), Constants.TRIANGLE_SIDE_ERROR);
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, -5), Constants.TRIANGLE_SIDE_ERROR);
            Assert.Throws<ArgumentException>(() => new Triangle(-3, -4, -5), Constants.TRIANGLE_SIDE_ERROR);
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 8), Constants.TRIANGLE_SUM_SIDES_ERROR);           // Ошибка по сумме длин сторон
        }

        /// <summary>
        /// Тестируем вычисление площади треугольника
        /// </summary>
        [Test]
        public void TriangleCalculateAreaTest()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            var triangleArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, triangleArea);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [Test]
        public void RightAngleTriangleTest()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            // Assert
            Assert.IsTrue(isTriangleRightAngled);
        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [Test]
        public void NotRightAngleTriangleTest()
        {
            // Arrange
            var triangle = new Triangle(6, 2, 5);

            // Act
            var isTriangleRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.IsFalse(isTriangleRightAngled);
        }
    }
}
