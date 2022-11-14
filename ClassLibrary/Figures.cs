using System;

namespace ClassLibrary
{
    public class Figures
    {
        private double a, b, c, r;
        string er = "";

        public Figures(double r)//круг
        {
            if (r > 0)
                this.r = r;
            else throw new ArgumentException("Значения должны быть строго больше 0");
        }
        public Figures(double a, double b, double c)//треугольник
        {
            if (a > 0 && b > 0 && c > 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;

            }//throw new Exception("Значения должны быть строго больше 0")
            else throw new ArgumentException("Значения должны быть строго больше 0");
        }
        //расчёт пл круга
        public dynamic area_of_a_circle() => Math.Round(Math.PI * Math.Pow(r, 2), 4);

        //расчёт пл треугольника
        public dynamic area_of_a_triangle()
        {
            var p = (a + b + c) / (2); //поиск полупериметра
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //нахождение  площади треугольника
            return S;
        }

    }
}