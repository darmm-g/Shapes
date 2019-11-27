using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Triangle : Shape
    {
        /// <summary>
        /// Сторона A
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double SideC { get; }

        private Lazy<bool> isRight => new Lazy<bool>(CalculateIfTriangleRight);

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight => isRight.Value;


        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        public Triangle(double a, double b, double c)
        {
            if (a<=0 || b<=0 || c<=0)
            {
                throw new ArgumentOutOfRangeException("Сторона меньше либо равна 0");
            }

            if (a>(b+c) || b>(c+a) || c>(a+b))
            {
                throw new ArgumentOutOfRangeException("Сторона треугольника больше суммы двух других сторон.");
            }

            SideA = a;
            SideB = b;
            SideC = c;
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь</returns>
        public override double GetArea()
        {
            // Расчет по формуле Герона
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        private bool CalculateIfTriangleRight()
        {
            double a2 = Math.Pow(SideA, 2);
            double b2 = Math.Pow(SideB, 2);
            double c2 = Math.Pow(SideC, 2);
            return ((a2 == b2 + c2) || (b2 == a2 + c2) || (c2 == a2 + b2));
        }
    }
}
