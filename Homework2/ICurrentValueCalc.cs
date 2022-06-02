namespace Homework2
{
    public interface ICurrentValueCalc
    {
        int Nominal { get; set; }
        double Price { get; set; }
        string TransType { get; set; }
        double CurrentValue { get; set; }

        void CurrentValueCalculation();

    }
}