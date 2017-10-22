using System;

namespace refactorVolumeOfPyramid
{
    class Program
    {
        static void Main()
        {
            double lenght, width, height = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            height = double.Parse(Console.ReadLine());
            height = (lenght + width + height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", height);

        }
    }
}
