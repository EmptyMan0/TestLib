using System;


namespace ClassLibrary
{
    public class Circle : iFigure
    {
        public Circle(double r)
        {
            if (r > 0)
                Radius = r;
            else throw new Exception("Значения должны быть строго больше 0");
        }

        public double Radius { get; }

        public double GetSquare() => Math.Round(Math.PI * Math.Pow(Radius, 2), 4);
       
    }
}
