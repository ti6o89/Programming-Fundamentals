using System;

namespace SieveofEratosthenes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] prime = new bool[n+1];

            for (int i = 2; i <= n; i++)
            {
                prime[i] = true;
            }
            for (int i = 2; i <= n; i++)
            {
                if (!prime[i])
                {
                    continue;
                }
                Console.Write($"{i} ");
                for (int j = i+i; j <= n; j+=i)
                {
                    prime[j] = false;
                }
            }
        }
    }
}
