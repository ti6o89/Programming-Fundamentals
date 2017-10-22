using System;

namespace rectanglePropertis
{
    class Program
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double perimeter = (w + h) * 2;
            double area = w * h;
            double diagonal = Math.Sqrt((w * w) + (h * h));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
