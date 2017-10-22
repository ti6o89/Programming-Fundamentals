using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factoraial = 1;
            for (int i = 2; i <= number; i++)
            {
                factoraial *= i;
            }
            Console.WriteLine(factoraial);
        }
    }
}
