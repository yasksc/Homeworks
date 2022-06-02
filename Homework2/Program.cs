using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Enter number of shares:");
                int nominal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter price per share:");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter transaction type (Buy or Sell):");
                string transType = Console.ReadLine();
                Console.WriteLine(new string('-', 30));

                CurrentValueCalc inst = new CurrentValueCalc(nominal, price, transType);
                inst.CurrentValueCalculation();
                Console.WriteLine("Press Enter to continue or Esc to exit");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
