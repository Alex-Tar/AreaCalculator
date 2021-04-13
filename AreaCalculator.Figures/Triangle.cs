using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Класс Треугольник
    /// </summary>
    public class Triangle : FigureBase
    {
        /// <summary>
        /// Длина первой стороны треугольника
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Длина второй стороны треугольника
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Длина третьей стороны треугольника
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Треугольник является прямоугольным
        /// </summary>
        public bool IsRightAngled { get; }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="firstSide">Длина первой стороны треугольника</param>
        /// <param name="secondSide">Длина второй стороны треугольника</param>
        /// <param name="thirdSide">Длина третьей стороны треугольника</param>
        /// <exception cref="ArgumentException">Если длина хотя бы одной из сторон меньше, либо равно 0 или длина любой стороны больше либо равна сумме длин двух других сторон</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            // Длина всех сторон должна быть больше 0
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException(Constants.TRIANGLE_SIDE_ERROR);
            }
            else if (((firstSide + secondSide) <= thirdSide) ||              // Длина любой стороны должна быть всегда меньше суммы длин двух других сторон (вариант вырожденного треугольника не рассматриваем)
                    ((firstSide + thirdSide) <= secondSide) ||
                    ((secondSide + thirdSide) <= firstSide))
            {
                throw new ArgumentException(Constants.TRIANGLE_SUM_SIDES_ERROR);
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            IsRightAngled = CheckIsRightAngled();
        }

        /// <summary>
        /// Проверка - является ли треугольник прямоугольным
        /// </summary>
        /// <returns>true - является, иначе false</returns>
        private bool CheckIsRightAngled()
        {
            List<double> sortedSides = new List<double> { FirstSide, SecondSide, ThirdSide }.OrderByDescending(x => x).ToList();

            return Math.Pow(sortedSides[0], 2) == Math.Pow(sortedSides[1], 2) + Math.Pow(sortedSides[2], 2);
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double CalculateArea()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }
    }
}
