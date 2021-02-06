using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Point
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public Point()
        {
            y = 0;
            x = 0;
        }

        public Point(double a, double b)
        {
            x = a;
            y = b;
        }

        public override string ToString()
        {
            return "x = " + x + " y = " + y;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double DistanceToPoint(Point a)
        {
            return Math.Sqrt((x - a.x) * (x - a.x) + (y - a.y) * (y - a.y));
        }

        public static double DistanceBetweenTwoPoints(Point a, Point b)
        {
            return Math.Sqrt((b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y));
        }

        public Point Shift(double a, double b)
        {
            return new Point(x + a, y + b);
        }
    }
}
