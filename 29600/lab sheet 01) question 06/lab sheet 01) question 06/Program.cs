
using System;

namespace LabSheet01Question06
{
    internal class Program
    {
        static string studentName;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name:");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter exam marks:");
            int examMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Grade: " + (Grade(examMarks))); 

           
        }

        static string Grade(int marks)
        {
            if (marks >= 75 && marks <= 100)
            {
                return "A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                return "B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                return "C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                return "D";
            }
            else
            {
                return "Fail";
            }
        }

    }
}
