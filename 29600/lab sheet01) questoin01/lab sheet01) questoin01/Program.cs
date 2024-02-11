using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet01__questoin01
{
    internal class Program
    {
        static double length, wide, area;
        static void Main(string[] args)
        {
            Console.WriteLine("calculate the area of a rectangle");
            Console.WriteLine(" Enter Length :");
              length =double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter Wide:");
            wide= double.Parse(Console.ReadLine());
            Area();
           
        }
        public static void Area()
        {
            area = length * wide;
            Console.WriteLine(" Area is:" + area);
        }

    }
}
