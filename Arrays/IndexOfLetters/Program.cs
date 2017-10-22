using System;
using System.Linq;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var word =Console.ReadLine().ToArray();
            var alphabet = ("abcdefghijklmnopqrstuvwxyz").ToArray();
            char firstLetter = char.Parse("a");
            char lastLetter = char.Parse("z");

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i]==alphabet[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }
        }
    }
}
