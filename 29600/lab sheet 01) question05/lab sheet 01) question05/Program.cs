using System;

namespace LabSheet01Question05
{
    public class Program
    {
        static int number;

        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table");

            Console.WriteLine("Enter a number you want");
            number = int.Parse(Console.ReadLine());
            Multiplication();
        }

        public static void Multiplication()
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = i * number;
                Console.WriteLine($"{i} * {number} = {result}");
            }
        }
    }
}
