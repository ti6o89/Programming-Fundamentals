using System;
using System.Collections.Generic;
using System.Linq;

namespace AvarageGrades
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split();
                string studentName = studentsInfo[0];
                List<double> grades = new List<double>();
                for (int j = 1; j < studentsInfo.Length; j++)
                {
                    double grade = double.Parse(studentsInfo[j]);
                    grades.Add(grade);
                }
                Student student = new Student();
                student.Name = studentName;
                student.Grades = grades;

                students.Add(student);
            }
            foreach (Student student in students.Where(s => s.AverageGrades() >= 5)
                .OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrades()))
            {
                Console.WriteLine("{0} -> {1:f2}",student.Name, student.AverageGrades());
            }
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrades()
        {
            double averageGrade = this.Grades.Average();
            return averageGrade;
        }
    }
}
