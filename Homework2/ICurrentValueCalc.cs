namespace Homework2
{
    public interface ICurrentValueCalc
    {
        int Nominal { get; set; }
        double PriceTrade { get; set; }
        double PriceOrigin { get; set; }
        string TransType { get; set; }
        double CurrentValue { get; set; }
        double ProfitLoss { get; set; }

        void CurrentValueCalculation();

    }
}