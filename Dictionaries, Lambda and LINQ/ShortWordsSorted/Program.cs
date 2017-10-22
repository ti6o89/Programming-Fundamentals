using System;
using System.Linq;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower();
                
                
            string[] shortWord = text.Split(new char[] { '.', ',', ':',  '(', ')', '[', ']', '"', '\\', '/', '!', '?', ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();
            Console.WriteLine(string.Join(", ",shortWord));
        }
    }
}
