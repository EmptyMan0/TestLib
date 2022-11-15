using ClassLibrary;
using System;

namespace LibFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pm = new Program();
            pm.check_input();
        }
        dynamic check_input()
        {
            try
            {
                Console.WriteLine("Выбирете фигуру: 1.Круг. 2.Треугльник");
                string type_figure = Console.ReadLine();
                switch (type_figure)
                {
                    case "1":
                        Console.Write("Введите радиус круга в см для вычисления площади r = ");
                        var r = Convert.ToDouble(Console.ReadLine());
                        var rez = new Circle(r).GetSquare();
                        Console.WriteLine($"Площадь круга {rez} кв.см");
                        break;

                    case "2":
                        Console.WriteLine("Введите 3 стороны треугольника(a, b, c) через пробел в см, для вычисления площади");
                        string line = Console.ReadLine();
                        string[] splitString = line.Split(' ');

                        var a = double.Parse(splitString[0]);
                        var b = double.Parse(splitString[1]);
                        var c = double.Parse(splitString[2]);
                        var max = Math.Max(c, Math.Max(a, b));
                        var sum_perem = a + b + c;
                        //if (sum_perem -max)
                        //{
                        //    string pprt = "Наибольшая сторона треугольника должна быть меньше суммы других сторон";
                        //}
                        string ife = (c * c == a * a + b * b) ? "Введённый Вами треугольник равнобедренный"
                                                                : "Введённый Вами треугольник равносторонний";
                        Console.WriteLine($"{ife}");
                        Triangle sides = new Triangle(a, b, c);
                        Console.WriteLine($"Площадь треугольника равна {sides.GetSquare()} кв. см");
                        break;

                    default:
                        Console.Write("Такой фигуры нет в списке");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неверный ввод данных");
            }
            return 0;
        }
    }
}
