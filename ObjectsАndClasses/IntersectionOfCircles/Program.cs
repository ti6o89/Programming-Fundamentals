using System;
using System.Linq;

namespace IntersectionOfCircles
{
    class Program
    {
        static void Main()
        {
            int[] firstCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point firstPoint = new Point
            {
                X = firstCircleParams[0],
                Y = firstCircleParams[1]
            };
            Circle firstCircle = new Circle();
            firstCircle.Radius = firstCircleParams[2];
            firstCircle.Center = firstPoint;

            int[] secondCircleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point secondPoint = new Point
            {
                X = secondCircleParams[0],
                Y = secondCircleParams[1]
            };
            Circle secondCircle = new Circle();
            secondCircle.Radius = secondCircleParams[2];
            secondCircle.Center = secondPoint;

            Console.WriteLine(Circle.Intersect(firstCircle, secondCircle) ? "Yes" : "No");
        }

    }
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public static bool Intersect(Circle c1, Circle c2)
        {
            int deltaX = c2.Center.X - c1.Center.X;
            int deltaY = c2.Center.Y - c1.Center.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            int radiusSum = c1.Radius + c2.Radius;

            if (distance<=radiusSum)
            {
                return true;
            }
            return false;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
