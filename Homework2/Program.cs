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
            int nominal = 0;
            double priceOrigin = 0;
            double priceTrade = 0;

            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine(new string('-', 30));
                        Console.WriteLine("Enter number of shares:");
                        nominal = Convert.ToInt32(Console.ReadLine());
                        if (nominal < 0)
                        {
                            throw new Exception("Number of shares must be bigger than 0. Try to enter number of shares one more time:");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (nominal < 0);

                do
                {
                    try
                    {
                        Console.WriteLine(new string('-', 30));
                        Console.WriteLine("Enter origin price per share:");
                        priceOrigin = Convert.ToDouble(Console.ReadLine());
                        if (priceOrigin < 0)
                        {
                            throw new Exception("Original price must be bigger than 0. Try to enter original price one more time:");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (priceOrigin < 0);

                do
                {
                    try
                    {
                        Console.WriteLine(new string('-', 30));
                        Console.WriteLine("Enter trade price per share:");
                        priceTrade = Convert.ToDouble(Console.ReadLine());
                        if (priceTrade < 0)
                        {
                            throw new Exception("Trade price must be bigger than 0. Try to enter trade price one more time:");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (priceTrade < 0);

                Console.WriteLine("Enter transaction type (Buy or Sell):");
                string transTypeUser = Console.ReadLine();
                Console.WriteLine(new string('-', 30));

                CurrentValueCalc inst = new CurrentValueCalc(nominal, priceOrigin, priceTrade, transTypeUser);
                inst.CalculateCurrentValue();
                Console.WriteLine("Press Enter to continue or Esc to exit");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
