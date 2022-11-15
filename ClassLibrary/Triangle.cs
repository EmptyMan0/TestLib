using System;


namespace ClassLibrary
{
    public class Triangle : iFigure
    {
        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                EdgeA = a;
                EdgeB = b;
                EdgeC = c;
            }
            else throw new Exception("Значения должны быть строго больше 0");
        }
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }

        public double GetSquare()
        {
            var p = (EdgeA + EdgeB + EdgeC) / (2); //поиск полупериметра
            var S = Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC)); //нахождение  площади треугольника
            return S;
        }
    }
}
