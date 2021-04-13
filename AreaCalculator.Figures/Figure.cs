using System;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Класс неизвестной фигуры
    /// </summary>
    public class Figure : FigureBase
    {
        private FigureBase _figure;

        /// <summary>
        /// Фигура
        /// </summary>
        /// <param name="figure">Объект фигуры</param>
        /// <exception cref="ArgumentNullException">Если объект не существует (null)</exception>
        public Figure(FigureBase figure)
        {
            if (figure == null)
            {
                throw new ArgumentNullException("figure");
            }

            _figure = figure;
        }

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public override double CalculateArea()
        {
            return _figure.CalculateArea();
        }
    }
}
