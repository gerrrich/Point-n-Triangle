using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Triangle
    {
        public Point a { get; private set; }
        public Point b { get; private set; }
        public Point c { get; private set; }


        public Triangle(Point a, Point b, Point c)
        {
            double aa = Point.DistanceBetweenTwoPoints(a, b);
            double bb = Point.DistanceBetweenTwoPoints(c, b);
            double cc = Point.DistanceBetweenTwoPoints(a, c);
            if (aa + bb > cc && aa + cc > bb && cc + bb > aa)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
                throw new Exception("Точки на одной прямой");
        }

        public override string ToString()
        {
            return a.ToString() + "\n" + b.ToString() + "\n" + c.ToString();
        }

        public double Perimeter()
        {
            return Point.DistanceBetweenTwoPoints(a, b) + Point.DistanceBetweenTwoPoints(a, c) + Point.DistanceBetweenTwoPoints(c, b);
        }

        public double Area()
        {
            double aa = Point.DistanceBetweenTwoPoints(a, b);
            double bb = Point.DistanceBetweenTwoPoints(c, b);
            double cc = Point.DistanceBetweenTwoPoints(a, c);
            double p = (aa + bb + cc) / 2;
            return Math.Sqrt(p * (p - aa) * (p - bb) * (p - cc));
        }

        public bool IsRight()
        {
            double aa = Point.DistanceBetweenTwoPoints(a, b);
            double bb = Point.DistanceBetweenTwoPoints(c, b);
            double cc = Point.DistanceBetweenTwoPoints(a, c);
            aa = Math.Round(aa * aa, 5);
            bb = Math.Round(bb * bb, 5);
            cc = Math.Round(cc * cc, 5);
            if (aa + bb == cc || aa + cc == bb || cc + bb == aa)
                return true;
            else
                return false;
        }

        public bool IsIsosceles()
        {
            double aa = Point.DistanceBetweenTwoPoints(a, b);
            double bb = Point.DistanceBetweenTwoPoints(c, b);
            double cc = Point.DistanceBetweenTwoPoints(a, c);
            if (aa == bb || aa == cc || cc == bb)
                return true;
            else
                return false;
        }

        public bool IsEquilateral()
        {
            double aa = Point.DistanceBetweenTwoPoints(a, b);
            double bb = Point.DistanceBetweenTwoPoints(c, b);
            double cc = Point.DistanceBetweenTwoPoints(a, c);
            if (aa == bb && aa == cc)
                return true;
            else
                return false;
        }
    }
}
