using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    /// <summary>
    /// Класс для быстрой работы с фигурами
    /// </summary>
    public static class ShapeHelper
    {
        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns>Площадь</returns>
        public static double GetArea(double radius) => new Circle(radius).GetArea();

        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <returns>Площадь</returns>
        public static double GetArea(double a, double b, double c) => new Triangle(a, b, c).GetArea();

    }
}
