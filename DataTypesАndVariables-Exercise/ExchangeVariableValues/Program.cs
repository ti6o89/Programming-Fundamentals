using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int oldA = int.Parse(Console.ReadLine());
            int oldB = int.Parse(Console.ReadLine());
            int newA = oldB;
            int newB = oldA;
            Console.WriteLine("Before:");
            Console.WriteLine("a = "+oldA);
            Console.WriteLine("b = " +oldB );
            Console.WriteLine("After:");
            Console.WriteLine("a = " + newA);
            Console.WriteLine("b = " + newB);
        }
    }
}
