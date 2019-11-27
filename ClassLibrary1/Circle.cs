using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус меньше либо равен 0");
            }

            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>Площадь</returns>
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
