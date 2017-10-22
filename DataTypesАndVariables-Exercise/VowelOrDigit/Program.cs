using System;

namespace VowelOrDigit
{
    class Program
    {
        static void Main()
        {
            string symbol = Console.ReadLine().ToLower();
            switch (symbol)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    Console.WriteLine("digit");
                    break;
                case "a":
                case "u":
                case "o":
                case "e":
                case "i":
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
