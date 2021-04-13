using System;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Класс Круга
    /// </summary>
    public class Circle : FigureBase
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException">Если радиус круга меньше либо равно 0</exception>
        public Circle(double radius)
        {
            // Радиус должен быть больше 0
            if (radius <= 0)
            {
                throw new ArgumentException(Constants.CIRCLE_RADIUS_ERROR);
            }

            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
