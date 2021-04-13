using System;
using AreaCalculator.Figures;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class AreaCalculatorFigureTests
    {
        /// <summary>
        /// Тестируем попытку создания пустого (null) объекта
        /// </summary>
        [Test]
        public void CircleIncorrectRadiusTest()
        {
            Assert.Throws<ArgumentNullException>(() => new Figure(null));
        }

        /// <summary>
        /// Тестируем вычисление площади произвольной фигуры
        /// </summary>
        [Test]
        public void FigureCalculateAreaTest()
        {
            // Arrange
            Figure figure = new Figure(new Circle(5));
            double rightArea = Math.PI * Math.Pow(5, 2);

            // Act
            double figureArea = figure.CalculateArea();

            // Assert
            Assert.AreEqual(rightArea, figureArea);
        }
    }
}
