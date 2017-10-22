using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (wordCount.ContainsKey(words[i]))
                {
                    wordCount[words[i]] += 1;
                }
                else
                {
                    wordCount[words[i]] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var word in wordCount.Keys)
            {
                if (wordCount[word] %2==1)
                {
                    result.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",result ));
        }
    }
}
