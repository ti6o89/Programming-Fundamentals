using System;

namespace intigerToHexAndBinary
{
    class Program
    {
        static void Main()
        {
            int decValue = int.Parse(Console.ReadLine());
            string hexValue = decValue.ToString("X");
            string binary = Convert.ToString(decValue, 2);
            Console.WriteLine(hexValue);
            Console.WriteLine(binary);
        }
    }
}
