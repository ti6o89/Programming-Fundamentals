using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstletter = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondtletter = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int minLetter = Math.Min(firstletter.Length, secondtletter.Length);
            bool diffrent = false;

            for (int i = 0; i < minLetter; i++)
            {
                if (firstletter[i]>secondtletter[i])
                {
                    Console.WriteLine(string.Join("", secondtletter));
                    Console.WriteLine(string.Join("", firstletter));
                    diffrent = true;
                    break;
                }
                else if (secondtletter[i]>firstletter[i])
                {
                    Console.WriteLine(string.Join("", firstletter));
                    Console.WriteLine(string.Join("", secondtletter));
                    diffrent = true;
                    break;
                }
            }
            if (!diffrent)
            {
                if (firstletter.Length>secondtletter.Length)
                {
                    Console.WriteLine(string.Join("", secondtletter));
                    Console.WriteLine(string.Join("", firstletter));
                }
                else
                {
                    Console.WriteLine(string.Join("", firstletter));
                    Console.WriteLine(string.Join("", secondtletter));
                }
            }
        }
    }
}
