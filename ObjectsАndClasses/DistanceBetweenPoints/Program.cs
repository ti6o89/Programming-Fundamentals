﻿using System;
using System.Linq;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            double distance = CalcDistance(p1, p2);

            Console.WriteLine("Distance: {0:f3}", distance);
        }
        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }
    }
     class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
