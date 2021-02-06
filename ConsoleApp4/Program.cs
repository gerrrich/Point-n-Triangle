using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(new Point(1, 1), new Point(2, 1), new Point(1, 2));
            Console.WriteLine("Координаты точек треугольника:\n"+triangle);
            Console.WriteLine("Площадь: "+triangle.Area());
            Console.WriteLine("Равносторонний: " + triangle.IsEquilateral());
            Console.WriteLine("Равнобедренный: " + triangle.IsIsosceles());
            Console.WriteLine("Прямоугольный: " + triangle.IsRight());
            Console.WriteLine("Периметр: " + triangle.Perimeter());
        }
    }
}
