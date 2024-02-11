using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet01__question03
{
    internal class Program
    { static int  x,sum=0;
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a positive integer");
            x = int.Parse(Console.ReadLine());
            if (0 > x) { Console.WriteLine(" ERROR!"); }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    sum += i;
                }
                Console.WriteLine(" sum is :" + sum);
            }
        }  
    }
}
