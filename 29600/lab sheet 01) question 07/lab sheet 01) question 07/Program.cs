using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_01__question_07
{
    internal class Program
    {
        static double current_balance = 10000.00;
      
        static void Main(string[] args)
        {

           
            Console.WriteLine("Select operation\n1 =Check balance \n2 =Deposit money\n3 =Withdraw money");

            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Checkbalance();
                    break;
                case 2:
                    Depositmoney();
                    break;
                case 3:
                    Withdrawmoney();
                      break;

                default:Console.WriteLine(" Please Try Again");
                    break;
            }
        }
        public static void Checkbalance()
        {
           
            Console.WriteLine(" Your current balance is: (Rs)" + current_balance);
        }
        public static void Depositmoney()
        {
            Console.WriteLine("Enter your deposit amount(Rs)");

            double depositAmount  = float.Parse(Console.ReadLine());
            double newbalance = depositAmount + current_balance;
            Console.WriteLine(" Your new balance is: " + newbalance);
        }
        public static void Withdrawmoney()
        {
            Console.WriteLine("Enter your withdraw amount(Rs)");

            double withdrawAmount = float.Parse(Console.ReadLine());
            double newbalance =  current_balance-withdrawAmount;
            Console.WriteLine(" Your current balance is: " + newbalance);
        }

    }
}
