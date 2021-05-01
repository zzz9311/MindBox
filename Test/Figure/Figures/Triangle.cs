using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Figure.Figures
{
    public class Triangle : Figure
    {
        public double FirstEdge { get; private set; }
        public double SecondEdge { get; private set; }
        public double ThirdEdge { get; private set; }
        public double Perimeter { get; private set; }
        public bool IsRight => CheckIsRight();

        public Triangle(double firstEdge, double secondEdge, double thirdEdge)
        {
            if (firstEdge < 0 || secondEdge < 0 || thirdEdge < 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше 0.");
            }

            FirstEdge = firstEdge;
            SecondEdge = secondEdge;
            ThirdEdge = thirdEdge;

            if(!IsValideTriangle())
            {
                throw new ArgumentException("Cумма двух сторон треугольника всегда должна быть больше третей стороны.");
            }
        }

        public bool IsValideTriangle()
        {
            double MaxEdge = Math.Max(FirstEdge, Math.Max(SecondEdge, ThirdEdge));
            double Perimeter = FirstEdge + SecondEdge + ThirdEdge;
            if(Perimeter-(MaxEdge+MaxEdge) <= 0)
            {
                return false;
            }
            this.Perimeter = Perimeter;
            return true;
        }

        public override double GetSquare()
        {
            double HalfPerimeter = Perimeter / 2;
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - FirstEdge) * (HalfPerimeter - SecondEdge) * (HalfPerimeter - ThirdEdge));
        }
        private bool CheckIsRight()
        {
            return CheckRectangular(FirstEdge, SecondEdge, ThirdEdge) || CheckRectangular(FirstEdge, ThirdEdge, SecondEdge) || CheckRectangular(ThirdEdge, SecondEdge, FirstEdge);
        }

        private bool CheckRectangular(double firstEdge,double secondEdge, double thirdEdge)
        {
            return Math.Pow(firstEdge, 2) + Math.Pow(secondEdge, 2) == Math.Pow(thirdEdge, 2);
        }
    }
}
