using System;

namespace printAscii
{
    class Program
    {
        static void Main()
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            string symbols = "";
            for (int i = firstChar; i <= lastChar; i++)
            {
                char c = Convert.ToChar(i);
                string d = c.ToString();
                symbols += d+" ";
            }
            Console.WriteLine(symbols);
        }
    }
}
