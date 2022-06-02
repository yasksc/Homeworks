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
        private double _priceTrade;
        private double _priceOrigin;

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
                    Console.WriteLine("Nominal must be bigger than 0");   
                }
            }
        }

        public double PriceTrade
        {
            get { return _priceTrade; }
            set
            {
                if (value > 0)
                {
                    _priceTrade = value;
                }
                else
                {
                    Console.WriteLine("Price must be bigger than 0");
                }
            }
        }

        public double PriceOrigin
        {
            get { return _priceOrigin; }
            set
            {
                if (value > 0)
                {
                    _priceOrigin = value;
                }
                else
                {
                    Console.WriteLine("Price must be bigger than 0");
                }
            }
        }

        public string TransType { get; set; }
        public double CurrentValue { get; set; }
        public double ProfitLoss { get; set; }

        public CurrentValueCalc(int nominal, double priceOrigin, double priceTrade, string transType)
        {
            Nominal = nominal;
            PriceOrigin = priceOrigin;
            PriceTrade = priceTrade;
            TransType = transType;
        }
        public void CurrentValueCalculation()
        {
            TransactionType trcType;
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), TransType, true);
            CurrentValue = (int)trcType * Nominal * PriceOrigin;
            ProfitLoss = ((int) trcType < 0) ? (PriceTrade - PriceOrigin) * Nominal : 0.0;
            Console.WriteLine($"Current value: {CurrentValue}\n" +
                              $"Profit/Loss: {ProfitLoss}");
        }
    }
}