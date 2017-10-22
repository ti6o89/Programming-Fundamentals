using System;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            int[] seq = new int[n];
            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                int count = k;
                for (int j =i-1 ; j >= 0; j--)
                {
                    if (count==0)
                    {
                        break;
                    }
                    sum += seq[j];
                    count--;
                }
                seq[i] = sum;
            }
            Console.WriteLine(string.Join(" ",seq));
        }
    }
}
