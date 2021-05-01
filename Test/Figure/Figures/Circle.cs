using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Figure.Figures
{
    public class Circle : Figure
    {
        private double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должно быть положительным числом.");
            }
            Radius = radius;
        }
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
