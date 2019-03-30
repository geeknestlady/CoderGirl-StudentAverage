using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentAverage
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = CreateListOfStudents();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} Average: {student.GetAverage()}");
            }

            Console.ReadLine();
        }

        public static Student CreateStudentRecord(string line)
        {
            Student student = new Student();
            string[] properties = line.Split(" ");
            student.Name = properties[0];
            string[] scoreString = new string[properties.Length - 1];
            for (int i = 0; i < properties.Length; i++)
            {
                if(i != 0)
                {
                    scoreString[i-1] = properties[i];
                }

            }
            int[] scores = new int[scoreString.Length];
            scores = Array.ConvertAll(scoreString, int.Parse);
            student.Scores = scores;
                       
            return student;
        }
        public static List<Student> CreateListOfStudents()
        {
            List<Student> students = new List<Student>();
            foreach (string line in File.ReadAllLines(@"c:studentdata.txt"))
            {
                Student student = CreateStudentRecord(line);
                students.Add(student);
            }

            return students;
        }
   
    }
}