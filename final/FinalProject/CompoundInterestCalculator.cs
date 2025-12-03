public class CompoundInterestCalculator : InterestCalculator
{
    // Attributes/Member Variables
    private enum _compoundingFrequency
    {
        Daily,
        Monthly,
        Quarterly,
        Annually
    }


    // Methods
    public decimal CalculateInterest(decimal balance, decimal rate, DateTime timePeriod)
    {
        return 0m;
    }
}