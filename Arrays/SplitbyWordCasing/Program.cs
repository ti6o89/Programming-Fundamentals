using System;
using System.Collections.Generic;

namespace SplitbyWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separator = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' ' };
            var words = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var upperCaseWords = new List<string>();
            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var w in words)
            {
                var type = GetWordType(w);
                if (type==WordType.Uppercase)
                {
                    upperCaseWords.Add(w);
                }
                else if (type==WordType.Lowercase)
                {
                    lowerCaseWords.Add(w);
                }
                else
                {
                    mixedCaseWords.Add(w);
                }
            }

            Console.WriteLine("Lower-case: ", string.Join(", ",lowerCaseWords));
            Console.WriteLine("Mixed-case: ", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: ", string.Join(", ", upperCaseWords));
        }
        enum WordType {Uppercase, Lowercase, Mixedcase}

        static WordType GetWordType(string word)
        {
            var upperLeters = 0;
            var lowerLetter = 0;
            foreach (var l in word)
            {
                if (char.IsUpper(l))
                {
                    upperLeters++;
                }
                else if (char.IsLower(l))
                {
                    lowerLetter++;
                }
            }
            if (lowerLetter==word.Length)
            {
                return WordType.Lowercase;
            }
            else if (upperLeters==word.Length)
            {
                return WordType.Uppercase;
            }
            else
            {
                return WordType.Mixedcase;
            }
        }
    }
}
