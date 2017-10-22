using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Student> allStudents = new Dictionary<string, Student>();

            while (!input.Equals("end of dates"))
            {
                string[] commandArgs = input.Split(' ', ',');
                string studentName = commandArgs[0];

                if (!allStudents.ContainsKey(studentName))
                {
                    allStudents.Add(studentName, new Student());
                    allStudents[studentName].Dates = new List<DateTime>();
                    allStudents[studentName].Comments = new List<string>();
                }
                for (int i = 1; i < commandArgs.Length; i++)
                {
                    DateTime date = DateTime.ParseExact(commandArgs[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    allStudents[studentName].Dates.Add(date);
                }
                
                

                input = Console.ReadLine();
            }


            string input2 = Console.ReadLine();

            while (!input2.Equals("end of comments"))
            {
                string[] comment = input2.Split('-');
                string commentName = comment[0];
                string commentar = comment[1];

                if (!allStudents.ContainsKey(commentName))
                {
                    input2 = Console.ReadLine();
                    continue;
                }
                else
                {
                    allStudents[commentName].Comments.Add(commentar);
                }

                input2 = Console.ReadLine();
            }

            foreach (var student in allStudents.OrderBy(x=>x.Key))
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                if (student.Value.Comments.Count>0)
                {
                    Console.WriteLine($"- {string.Join("\n-", student.Value.Comments)}");
                }
                Console.WriteLine("Dates attended:");

                if (student.Value.Dates.Count>0)
                {
                    foreach (var date in student.Value.Dates.OrderBy(x=>x.Date))
                    {
                        Console.WriteLine($"-- {date:dd/MM/yyyy}");
                    }
                }
            }
        }
    }
    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
