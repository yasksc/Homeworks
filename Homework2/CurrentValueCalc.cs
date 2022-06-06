using System;

namespace Homework2
{
    public class CurrentValueCalc : ICurrentValueCalc
    {
        public int Nominal { get; set; }
        public double PriceTrade { get; set; }
        public double PriceOrigin { get; set; }
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

        public void CalculateCurrentValue()
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