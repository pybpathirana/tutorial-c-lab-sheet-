using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_01__question_02
{
    internal class Program
    {  static int x;
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Enter a number");
                x= int.Parse(Console.ReadLine());

                if (x % 2 == 0) { Console.WriteLine(" It is even number"); }

                else if (x % 2 == 1) { Console.WriteLine(" It is odd number"); }

                else { Console.WriteLine(" Enter valied input"); }

            }
        }
    }
}
