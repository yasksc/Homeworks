using System;

namespace Homework2
{
    enum TransactionType
    {
        Buy = 1,
        Sell = -1
    }
    public class CurrentValueCalc : ICurrentValueCalc
    {
        private int _nominal;
        private double _price;

        public int Nominal
        {
            get { return _nominal;}
            set {
                if (value > 0)
                {
                    _nominal = value;
                }
                else
                {
                    Console.WriteLine("Nominal must be biger than 0");   
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price must be biger than 0");
                }
            }
        }

        public string TransType { get; set; }
        public double CurrentValue { get; set; }

        public CurrentValueCalc(int nominal, double price, string transType)
        {
            Nominal = nominal;
            Price = price;
            TransType = transType;
        }
        public void CurrentValueCalculation()
        {
            TransactionType trcType;
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), TransType, true);
            CurrentValue += (int)trcType * Nominal * Price;
            Console.WriteLine($"Current value: {CurrentValue}");
        }
    }
}