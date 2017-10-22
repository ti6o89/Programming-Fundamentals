using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < input.Length; pos1++)
            {
                int pos2 = rnd.Next(input.Length);
                string temp = input[pos1];
                input[pos1] = input[pos2];
                input[pos2] = temp;
            }
            Console.WriteLine(string.Join("\r\n",input));

        }
    }
}
