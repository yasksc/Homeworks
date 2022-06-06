using System;

namespace Homework2
{
    public class CurrentValueCalc : ICurrentValueCalc
    {
        private int _nominal;
        private double _priceTrade;
        private double _priceOrigin;

        public int Nominal
        {
            get { return _nominal; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        _nominal = value;
                    }
                    else
                        throw new Exception("Number of shares must be bigger than 0");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public double PriceTrade
        {
            get { return _priceTrade; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        _priceTrade = value;
                    }
                    else
                        throw new Exception("Trade price must be bigger than 0");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public double PriceOrigin
        {
            get { return _priceOrigin; }
            set
            {
                try
                {
                    if (value > 0)
                    {
                        _priceOrigin = value;
                    }
                    else
                        throw new Exception("Original price must be bigger than 0");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public string TransactionTypeUser { get; set; }
        public double CurrentValue { get; set; }
        public double ProfitLoss { get; set; }


        public CurrentValueCalc(int nominal, double priceOrigin, double priceTrade, string transactionTypeUser)
        {
            Nominal = nominal;
            PriceOrigin = priceOrigin;
            PriceTrade = priceTrade;
            TransactionTypeUser = transactionTypeUser;
        }
        public void CurrentValueCalculation()
        {
            TransactionType trcType;
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), TransactionTypeUser, true);
            CurrentValue = (int)trcType * Nominal * PriceOrigin;
            ProfitLoss = ((int)trcType < 0) ? (PriceTrade - PriceOrigin) * Nominal : 0.0;
            Console.WriteLine($"Current value: {CurrentValue}\n" +
                              $"Profit/Loss: {ProfitLoss}");
        }
    }
}