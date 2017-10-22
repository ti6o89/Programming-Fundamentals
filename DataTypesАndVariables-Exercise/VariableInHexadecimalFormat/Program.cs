using System;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main()
        {
            string hexValue = Console.ReadLine();
            int decValue = Convert.ToInt32(hexValue);
            Console.WriteLine(decValue);
        }
    }
}
