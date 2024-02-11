using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_01__question_04



{
    internal class Program
    {
        static int number;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());

            Displyseries();
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int currentFib = 1;
            int previousFib = 1;

            for (int i = 2; i < n; i++)
            {
                int temp = currentFib;
                currentFib += previousFib;
                previousFib = temp;
            }

            return currentFib;
        }
        public static void Displyseries()
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(Fibonacci(i) + "\t");
            }
        }
    }
}

    