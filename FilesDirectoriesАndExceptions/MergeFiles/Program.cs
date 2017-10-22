using System;
using System.Collections.Generic;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileOne = File.ReadAllLines("FileOne.txt");
            string[] fileTwo = File.ReadAllLines("FileTwo.txt");
            File.WriteAllText("output.txt", "");

            List<int> numbers = new List<int>();
            foreach (var number in fileOne)
            {
                numbers.Add(int.Parse(number));
            }
            foreach (var num in fileTwo)
            {
                numbers.Add(int.Parse(num));
            }
            numbers.Sort();
            foreach (var item in numbers)
            {
                File.AppendAllText("output.txt", item.ToString() + Environment.NewLine);
            }
        }
    }
}
